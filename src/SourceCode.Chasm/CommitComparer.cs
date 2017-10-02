﻿using SourceCode.Clay.Collections.Generic;
using System;
using System.Collections.Generic;

namespace SourceCode.Chasm
{
    /// <summary>
    /// Represents a way to compare different <see cref="Commit"/> values.
    /// </summary>
    public abstract class CommitComparer : IEqualityComparer<Commit>
    {
        #region Constants

        /// <summary>
        /// Gets a <see cref="CommitComparer"/> that compares all fields of a <see cref="Commit"/> value.
        /// </summary>
        public static CommitComparer Default { get; } = new DefaultComparer();

        #endregion

        #region Constructors

        protected CommitComparer()
        { }

        #endregion

        #region IEqualityComparer

        /// <inheritdoc/>
        public abstract bool Equals(Commit x, Commit y);

        /// <inheritdoc/>
        public abstract int GetHashCode(Commit obj);

        #endregion

        #region Concrete

        private sealed class DefaultComparer : CommitComparer
        {
            internal DefaultComparer()
            { }

            public override bool Equals(Commit x, Commit y)
            {
                if (x.CommitUtc != y.CommitUtc) return false;
                if (!x.TreeId.Equals(y.TreeId)) return false;
                if (!StringComparer.Ordinal.Equals(x.CommitMessage, y.CommitMessage)) return false;
                if (!x.Parents.NullableEquals(y.Parents, CommitIdComparer.Default, true)) return false;

                return true;
            }

            public override int GetHashCode(Commit obj)
            {
                var h = 11;

                unchecked
                {
                    h = h * 7 + obj.TreeId.GetHashCode();
                    h = h * 7 + obj.CommitUtc.GetHashCode();
                    h = h * 7 + (obj.Parents?.Count ?? 42);
                    h = h * 7 + (obj.CommitMessage?.Length ?? 0);
                }

                return h;
            }
        }

        #endregion
    }
}