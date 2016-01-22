// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The create shared link arg object</para>
    /// </summary>
    public class CreateSharedLinkArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<CreateSharedLinkArg> Encoder = new CreateSharedLinkArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<CreateSharedLinkArg> Decoder = new CreateSharedLinkArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateSharedLinkArg" />
        /// class.</para>
        /// </summary>
        /// <param name="path">The path to share.</param>
        /// <param name="shortUrl">Whether to return a shortened URL.</param>
        /// <param name="pendingUpload">If it's okay to share a path that does not yet exist,
        /// set this to either <see cref="PendingUploadMode.File" /> or <see
        /// cref="PendingUploadMode.Folder" /> to indicate whether to assume it's a file or
        /// folder.</param>
        public CreateSharedLinkArg(string path,
                                   bool shortUrl = false,
                                   PendingUploadMode pendingUpload = null)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }

            this.Path = path;
            this.ShortUrl = shortUrl;
            this.PendingUpload = pendingUpload;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateSharedLinkArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public CreateSharedLinkArg()
        {
            this.ShortUrl = false;
        }

        /// <summary>
        /// <para>The path to share.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>Whether to return a shortened URL.</para>
        /// </summary>
        public bool ShortUrl { get; protected set; }

        /// <summary>
        /// <para>If it's okay to share a path that does not yet exist, set this to either <see
        /// cref="PendingUploadMode.File" /> or <see cref="PendingUploadMode.Folder" /> to
        /// indicate whether to assume it's a file or folder.</para>
        /// </summary>
        public PendingUploadMode PendingUpload { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="CreateSharedLinkArg" />.</para>
        /// </summary>
        private class CreateSharedLinkArgEncoder : enc.StructEncoder<CreateSharedLinkArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(CreateSharedLinkArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                WriteProperty("short_url", value.ShortUrl, writer, enc.BooleanEncoder.Instance);
                if (value.PendingUpload != null)
                {
                    WriteProperty("pending_upload", value.PendingUpload, writer, Dropbox.Api.Sharing.PendingUploadMode.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="CreateSharedLinkArg" />.</para>
        /// </summary>
        private class CreateSharedLinkArgDecoder : enc.StructDecoder<CreateSharedLinkArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="CreateSharedLinkArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override CreateSharedLinkArg Create()
            {
                return new CreateSharedLinkArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(CreateSharedLinkArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "short_url":
                        value.ShortUrl = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "pending_upload":
                        value.PendingUpload = Dropbox.Api.Sharing.PendingUploadMode.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
