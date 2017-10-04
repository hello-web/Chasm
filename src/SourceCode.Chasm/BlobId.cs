using System;

namespace SourceCode.Chasm
{
    public struct BlobId : IEquatable<BlobId>
    {
        #region Constants

        /// <summary>
        /// A singleton representing an empty <see cref="BlobId"/> value.
        /// </summary>
        /// <value>
        /// The empty.
        /// </value>
        public static BlobId Empty { get; }

        #endregion

        #region Properties

        public Sha1 Sha1 { get; }

        #endregion

        #region De/Constructors

        public BlobId(Sha1 sha1)
        {
            Sha1 = sha1;
        }

        public void Deconstruct(out Sha1 sha1)
        {
            sha1 = Sha1;
        }

        #endregion

        #region IEquatable

        public bool Equals(BlobId other) => BlobIdComparer.Default.Equals(this, other);

        public override bool Equals(object obj)
            => obj is BlobId blobId
            && BlobIdComparer.Default.Equals(this, blobId);

        public override int GetHashCode() => BlobIdComparer.Default.GetHashCode(this);

        #endregion

        #region Operators

        public static bool operator ==(BlobId x, BlobId y) => BlobIdComparer.Default.Equals(x, y);

        public static bool operator !=(BlobId x, BlobId y) => !BlobIdComparer.Default.Equals(x, y); // not

        public override string ToString() => Sha1.ToString("N"); // Used by callsites as a proxy for .Sha1.ToString()

        #endregion
    }
}
