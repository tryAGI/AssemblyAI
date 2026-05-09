#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Realtime.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Server event indicating the streaming session has started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.Realtime.SessionBeginsPayload? Begin { get; init; }
#else
        public global::AssemblyAI.Realtime.SessionBeginsPayload? Begin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Begin))]
#endif
        public bool IsBegin => Begin != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBegin(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AssemblyAI.Realtime.SessionBeginsPayload? value)
        {
            value = Begin;
            return IsBegin;
        }

        /// <summary>
        /// Turn-based transcription result.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.Realtime.TurnPayload? Turn { get; init; }
#else
        public global::AssemblyAI.Realtime.TurnPayload? Turn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Turn))]
#endif
        public bool IsTurn => Turn != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTurn(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AssemblyAI.Realtime.TurnPayload? value)
        {
            value = Turn;
            return IsTurn;
        }

        /// <summary>
        /// Server event confirming session termination with statistics.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.Realtime.TerminationPayload? Termination { get; init; }
#else
        public global::AssemblyAI.Realtime.TerminationPayload? Termination { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Termination))]
#endif
        public bool IsTermination => Termination != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTermination(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AssemblyAI.Realtime.TerminationPayload? value)
        {
            value = Termination;
            return IsTermination;
        }

        /// <summary>
        /// Server-emitted validation, authentication or quota error. Typically delivered immediately before the WebSocket is closed by the server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.Realtime.ErrorPayload? Error { get; init; }
#else
        public global::AssemblyAI.Realtime.ErrorPayload? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AssemblyAI.Realtime.ErrorPayload? value)
        {
            value = Error;
            return IsError;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::AssemblyAI.Realtime.SessionBeginsPayload value) => new ServerEvent((global::AssemblyAI.Realtime.SessionBeginsPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.Realtime.SessionBeginsPayload?(ServerEvent @this) => @this.Begin;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::AssemblyAI.Realtime.SessionBeginsPayload? value)
        {
            Begin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::AssemblyAI.Realtime.TurnPayload value) => new ServerEvent((global::AssemblyAI.Realtime.TurnPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.Realtime.TurnPayload?(ServerEvent @this) => @this.Turn;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::AssemblyAI.Realtime.TurnPayload? value)
        {
            Turn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::AssemblyAI.Realtime.TerminationPayload value) => new ServerEvent((global::AssemblyAI.Realtime.TerminationPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.Realtime.TerminationPayload?(ServerEvent @this) => @this.Termination;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::AssemblyAI.Realtime.TerminationPayload? value)
        {
            Termination = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::AssemblyAI.Realtime.ErrorPayload value) => new ServerEvent((global::AssemblyAI.Realtime.ErrorPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.Realtime.ErrorPayload?(ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::AssemblyAI.Realtime.ErrorPayload? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::AssemblyAI.Realtime.ServerEventDiscriminatorType? type,
            global::AssemblyAI.Realtime.SessionBeginsPayload? begin,
            global::AssemblyAI.Realtime.TurnPayload? turn,
            global::AssemblyAI.Realtime.TerminationPayload? termination,
            global::AssemblyAI.Realtime.ErrorPayload? error
            )
        {
            Type = type;

            Begin = begin;
            Turn = turn;
            Termination = termination;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Termination as object ??
            Turn as object ??
            Begin as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Begin?.ToString() ??
            Turn?.ToString() ??
            Termination?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBegin && !IsTurn && !IsTermination && !IsError || !IsBegin && IsTurn && !IsTermination && !IsError || !IsBegin && !IsTurn && IsTermination && !IsError || !IsBegin && !IsTurn && !IsTermination && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.Realtime.SessionBeginsPayload, TResult>? begin = null,
            global::System.Func<global::AssemblyAI.Realtime.TurnPayload, TResult>? turn = null,
            global::System.Func<global::AssemblyAI.Realtime.TerminationPayload, TResult>? termination = null,
            global::System.Func<global::AssemblyAI.Realtime.ErrorPayload, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBegin && begin != null)
            {
                return begin(Begin!);
            }
            else if (IsTurn && turn != null)
            {
                return turn(Turn!);
            }
            else if (IsTermination && termination != null)
            {
                return termination(Termination!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.Realtime.SessionBeginsPayload>? begin = null,

            global::System.Action<global::AssemblyAI.Realtime.TurnPayload>? turn = null,

            global::System.Action<global::AssemblyAI.Realtime.TerminationPayload>? termination = null,

            global::System.Action<global::AssemblyAI.Realtime.ErrorPayload>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBegin)
            {
                begin?.Invoke(Begin!);
            }
            else if (IsTurn)
            {
                turn?.Invoke(Turn!);
            }
            else if (IsTermination)
            {
                termination?.Invoke(Termination!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AssemblyAI.Realtime.SessionBeginsPayload>? begin = null,
            global::System.Action<global::AssemblyAI.Realtime.TurnPayload>? turn = null,
            global::System.Action<global::AssemblyAI.Realtime.TerminationPayload>? termination = null,
            global::System.Action<global::AssemblyAI.Realtime.ErrorPayload>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBegin)
            {
                begin?.Invoke(Begin!);
            }
            else if (IsTurn)
            {
                turn?.Invoke(Turn!);
            }
            else if (IsTermination)
            {
                termination?.Invoke(Termination!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Begin,
                typeof(global::AssemblyAI.Realtime.SessionBeginsPayload),
                Turn,
                typeof(global::AssemblyAI.Realtime.TurnPayload),
                Termination,
                typeof(global::AssemblyAI.Realtime.TerminationPayload),
                Error,
                typeof(global::AssemblyAI.Realtime.ErrorPayload),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.Realtime.SessionBeginsPayload?>.Default.Equals(Begin, other.Begin) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.Realtime.TurnPayload?>.Default.Equals(Turn, other.Turn) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.Realtime.TerminationPayload?>.Default.Equals(Termination, other.Termination) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.Realtime.ErrorPayload?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
