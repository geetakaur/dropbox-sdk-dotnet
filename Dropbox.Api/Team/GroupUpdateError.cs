// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The group update error object</para>
    /// </summary>
    public class GroupUpdateError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupUpdateError> Encoder = new GroupUpdateErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupUpdateError> Decoder = new GroupUpdateErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupUpdateError" />
        /// class.</para>
        /// </summary>
        public GroupUpdateError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// ExternalIdAlreadyInUse</para>
        /// </summary>
        public bool IsExternalIdAlreadyInUse
        {
            get
            {
                return this is ExternalIdAlreadyInUse;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ExternalIdAlreadyInUse, or <c>null</c>.</para>
        /// </summary>
        public ExternalIdAlreadyInUse AsExternalIdAlreadyInUse
        {
            get
            {
                return this as ExternalIdAlreadyInUse;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupUpdateError" />.</para>
        /// </summary>
        private class GroupUpdateErrorEncoder : enc.StructEncoder<GroupUpdateError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupUpdateError value, enc.IJsonWriter writer)
            {
                if (value is ExternalIdAlreadyInUse)
                {
                    WriteProperty(".tag", "external_id_already_in_use", writer, enc.StringEncoder.Instance);
                    ExternalIdAlreadyInUse.Encoder.EncodeFields((ExternalIdAlreadyInUse)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupUpdateError" />.</para>
        /// </summary>
        private class GroupUpdateErrorDecoder : enc.UnionDecoder<GroupUpdateError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupUpdateError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupUpdateError Create()
            {
                return new GroupUpdateError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GroupUpdateError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "external_id_already_in_use":
                        return ExternalIdAlreadyInUse.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The new external ID is already being used by another group.</para>
        /// </summary>
        public sealed class ExternalIdAlreadyInUse : GroupUpdateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ExternalIdAlreadyInUse> Encoder = new ExternalIdAlreadyInUseEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ExternalIdAlreadyInUse> Decoder = new ExternalIdAlreadyInUseDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ExternalIdAlreadyInUse" />
            /// class.</para>
            /// </summary>
            private ExternalIdAlreadyInUse()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ExternalIdAlreadyInUse</para>
            /// </summary>
            public static readonly ExternalIdAlreadyInUse Instance = new ExternalIdAlreadyInUse();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ExternalIdAlreadyInUse" />.</para>
            /// </summary>
            private class ExternalIdAlreadyInUseEncoder : enc.StructEncoder<ExternalIdAlreadyInUse>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ExternalIdAlreadyInUse value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ExternalIdAlreadyInUse" />.</para>
            /// </summary>
            private class ExternalIdAlreadyInUseDecoder : enc.StructDecoder<ExternalIdAlreadyInUse>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ExternalIdAlreadyInUse"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ExternalIdAlreadyInUse Create()
                {
                    return new ExternalIdAlreadyInUse();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override ExternalIdAlreadyInUse DecodeFields(enc.IJsonReader reader)
                {
                    return ExternalIdAlreadyInUse.Instance;
                }
            }

            #endregion
        }
    }
}
