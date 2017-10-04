using Xunit;

namespace SourceCode.Chasm.Tests
{
    public static class CommitIRefTests
    {
        [Trait("Type", "Unit")]
        [Fact(DisplayName = nameof(CommitRef_has_empty_commitId))]
        public static void CommitRef_has_empty_commitId()
        {
            Assert.Equal(CommitId.Empty, CommitRef.Empty.CommitId);
            Assert.Equal(default, CommitRef.Empty);
            Assert.Equal(Sha1.Empty.ToString(), CommitRef.Empty.ToString());
        }

        [Trait("Type", "Unit")]
        [Fact(DisplayName = nameof(CommitRef_equality))]
        public static void CommitRef_equality()
        {
            var commitRef1 = new CommitRef(new CommitId(Sha1.Hash("abc")));
            var commitRef2 = new CommitRef(new CommitId(Sha1.Hash("abc")));
            var commitRef3 = new CommitRef(new CommitId(Sha1.Hash("def")));

            Assert.Equal(commitRef1.CommitId.Sha1.ToString(), commitRef1.ToString());
            Assert.Equal(commitRef2.CommitId.Sha1.ToString(), commitRef2.ToString());
            Assert.Equal(commitRef3.CommitId.Sha1.ToString(), commitRef3.ToString());

            Assert.Equal(commitRef1, commitRef2);
            Assert.Equal(commitRef1.GetHashCode(), commitRef2.GetHashCode());
            Assert.Equal(commitRef1.ToString(), commitRef2.ToString());

            Assert.NotEqual(CommitRef.Empty, commitRef1);
            Assert.NotEqual(CommitRef.Empty.GetHashCode(), commitRef1.GetHashCode());
            Assert.NotEqual(BlobId.Empty.ToString(), commitRef1.ToString());

            Assert.NotEqual(commitRef3, commitRef1);
            Assert.NotEqual(commitRef3.GetHashCode(), commitRef1.GetHashCode());
            Assert.NotEqual(commitRef3.ToString(), commitRef1.ToString());
        }
    }
}
