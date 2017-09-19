﻿namespace SourceCode.Chasm.IO.Bond.Wire
{
    internal static class CommitRefWireExtensions
    {
        public static int EstimateBytes(this CommitRefWire wire)
            => Sha1.ByteLen; // CommitId

        public static CommitRefWire Convert(this CommitRef model)
        {
            if (model == CommitRef.Empty)
                return default;

            var wire = new CommitRefWire
            {
                CommitId = model.CommitId.Sha1.Convert()
            };

            return wire;
        }

        public static CommitRef Convert(this CommitRefWire wire)
        {
            if (wire == null)
                return CommitRef.Empty;

            var sha1 = wire.CommitId.Convert();
            var commitId = new CommitId(sha1);

            var model = new CommitRef(commitId);
            return model;
        }
    }
}
