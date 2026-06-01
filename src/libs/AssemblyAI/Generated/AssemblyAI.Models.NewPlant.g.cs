#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NewPlant : global::System.IEquatable<NewPlant>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.Plant? Plant { get; init; }
#else
        public global::AssemblyAI.Plant? Plant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Plant))]
#endif
        public bool IsPlant => Plant != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPlant(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AssemblyAI.Plant? value)
        {
            value = Plant;
            return IsPlant;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Plant PickPlant() => IsPlant
            ? Plant!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Plant' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.NewPlantVariant2? NewPlantVariant2 { get; init; }
#else
        public global::AssemblyAI.NewPlantVariant2? NewPlantVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NewPlantVariant2))]
#endif
        public bool IsNewPlantVariant2 => NewPlantVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNewPlantVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AssemblyAI.NewPlantVariant2? value)
        {
            value = NewPlantVariant2;
            return IsNewPlantVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.NewPlantVariant2 PickNewPlantVariant2() => IsNewPlantVariant2
            ? NewPlantVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'NewPlantVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NewPlant(global::AssemblyAI.Plant value) => new NewPlant((global::AssemblyAI.Plant?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.Plant?(NewPlant @this) => @this.Plant;

        /// <summary>
        /// 
        /// </summary>
        public NewPlant(global::AssemblyAI.Plant? value)
        {
            Plant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NewPlant FromPlant(global::AssemblyAI.Plant? value) => new NewPlant(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NewPlant(global::AssemblyAI.NewPlantVariant2 value) => new NewPlant((global::AssemblyAI.NewPlantVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.NewPlantVariant2?(NewPlant @this) => @this.NewPlantVariant2;

        /// <summary>
        /// 
        /// </summary>
        public NewPlant(global::AssemblyAI.NewPlantVariant2? value)
        {
            NewPlantVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NewPlant FromNewPlantVariant2(global::AssemblyAI.NewPlantVariant2? value) => new NewPlant(value);

        /// <summary>
        /// 
        /// </summary>
        public NewPlant(
            global::AssemblyAI.Plant? plant,
            global::AssemblyAI.NewPlantVariant2? newPlantVariant2
            )
        {
            Plant = plant;
            NewPlantVariant2 = newPlantVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NewPlantVariant2 as object ??
            Plant as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Plant?.ToString() ??
            NewPlantVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPlant && IsNewPlantVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.Plant, TResult>? plant = null,
            global::System.Func<global::AssemblyAI.NewPlantVariant2, TResult>? newPlantVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlant && plant != null)
            {
                return plant(Plant!);
            }
            else if (IsNewPlantVariant2 && newPlantVariant2 != null)
            {
                return newPlantVariant2(NewPlantVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.Plant>? plant = null,

            global::System.Action<global::AssemblyAI.NewPlantVariant2>? newPlantVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlant)
            {
                plant?.Invoke(Plant!);
            }
            else if (IsNewPlantVariant2)
            {
                newPlantVariant2?.Invoke(NewPlantVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AssemblyAI.Plant>? plant = null,
            global::System.Action<global::AssemblyAI.NewPlantVariant2>? newPlantVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlant)
            {
                plant?.Invoke(Plant!);
            }
            else if (IsNewPlantVariant2)
            {
                newPlantVariant2?.Invoke(NewPlantVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Plant,
                typeof(global::AssemblyAI.Plant),
                NewPlantVariant2,
                typeof(global::AssemblyAI.NewPlantVariant2),
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
        public bool Equals(NewPlant other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.Plant?>.Default.Equals(Plant, other.Plant) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.NewPlantVariant2?>.Default.Equals(NewPlantVariant2, other.NewPlantVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NewPlant obj1, NewPlant obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NewPlant>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NewPlant obj1, NewPlant obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NewPlant o && Equals(o);
        }
    }
}
