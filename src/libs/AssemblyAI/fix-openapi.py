#!/usr/bin/env python3
"""Allow empty disabled transcript analysis results returned by AssemblyAI."""

import sys
from pathlib import Path


EXPECTED_REQUIRED = {
    "ContentSafetyLabelsResult": (
        "status",
        "results",
        "summary",
        "severity_score_summary",
    ),
    "TopicDetectionModelResult": ("status", "results", "summary"),
}


def main(path: Path) -> None:
    lines = path.read_text().splitlines(keepends=True)
    for schema, expected in EXPECTED_REQUIRED.items():
        start = next(
            (index for index, line in enumerate(lines) if line.rstrip() == f"    {schema}:"),
            None,
        )
        if start is None:
            raise ValueError(f"Missing {schema} schema")

        end = next(
            (
                index
                for index in range(start + 1, len(lines))
                if lines[index].startswith("    ")
                and not lines[index].startswith("     ")
                and lines[index].rstrip().endswith(":")
            ),
            len(lines),
        )
        required = next(
            (index for index in range(start + 1, end) if lines[index].rstrip() == "      required:"),
            None,
        )
        if required is None:
            continue

        last = required + 1
        while last < end and lines[last].startswith("        - "):
            last += 1
        actual = tuple(line.strip()[2:] for line in lines[required + 1 : last])
        if actual != expected:
            raise ValueError(f"Unexpected {schema} required properties: {actual!r}")
        del lines[required:last]

    path.write_text("".join(lines))


if __name__ == "__main__":
    main(Path(sys.argv[1]))
