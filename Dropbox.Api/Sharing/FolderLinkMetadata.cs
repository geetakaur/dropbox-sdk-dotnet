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
    /// <para>The metadata of a folder shared link</para>
    /// </summary>
    /// <seealso cref="SharedLinkMetadata" />
    public class FolderLinkMetadata : SharedLinkMetadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FolderLinkMetadata> Encoder = new FolderLinkMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FolderLinkMetadata> Decoder = new FolderLinkMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderLinkMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="url">URL of the shared link.</param>
        /// <param name="name">The linked file name (including extension). This never contains
        /// a slash.</param>
        /// <param name="linkPermissions">The link's access permissions.</param>
        /// <param name="id">A unique identifier for the linked file.</param>
        /// <param name="expires">Expiration time, if set. By default the link won't
        /// expire.</param>
        /// <param name="pathLower">The lowercased full path in the user's Dropbox. This always
        /// starts with a slash. This field will only be present only if the linked file is in
        /// the authenticated user's  dropbox.</param>
        /// <param name="teamMemberInfo">The team membership information of the link's owner.
        /// This field will only be present  if the link's owner is a team member.</param>
        /// <param name="contentOwnerTeamInfo">The team information of the content's owner.
        /// This field will only be present if the content's owner is a team member and the
        /// content's owner team is different from the link's owner team.</param>
        public FolderLinkMetadata(string url,
                                  string name,
                                  LinkPermissions linkPermissions,
                                  string id = null,
                                  sys.DateTime? expires = null,
                                  string pathLower = null,
                                  TeamMemberInfo teamMemberInfo = null,
                                  Dropbox.Api.Users.Team contentOwnerTeamInfo = null)
            : base(url, name, linkPermissions, id, expires, pathLower, teamMemberInfo, contentOwnerTeamInfo)
        {
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderLinkMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public FolderLinkMetadata()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FolderLinkMetadata" />.</para>
        /// </summary>
        private class FolderLinkMetadataEncoder : enc.StructEncoder<FolderLinkMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FolderLinkMetadata value, enc.IJsonWriter writer)
            {
                WriteProperty("url", value.Url, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("link_permissions", value.LinkPermissions, writer, Dropbox.Api.Sharing.LinkPermissions.Encoder);
                if (value.Id != null)
                {
                    WriteProperty("id", value.Id, writer, enc.StringEncoder.Instance);
                }
                if (value.Expires != null)
                {
                    WriteProperty("expires", value.Expires.Value, writer, enc.DateTimeEncoder.Instance);
                }
                if (value.PathLower != null)
                {
                    WriteProperty("path_lower", value.PathLower, writer, enc.StringEncoder.Instance);
                }
                if (value.TeamMemberInfo != null)
                {
                    WriteProperty("team_member_info", value.TeamMemberInfo, writer, Dropbox.Api.Sharing.TeamMemberInfo.Encoder);
                }
                if (value.ContentOwnerTeamInfo != null)
                {
                    WriteProperty("content_owner_team_info", value.ContentOwnerTeamInfo, writer, Dropbox.Api.Users.Team.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FolderLinkMetadata" />.</para>
        /// </summary>
        private class FolderLinkMetadataDecoder : enc.StructDecoder<FolderLinkMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FolderLinkMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FolderLinkMetadata Create()
            {
                return new FolderLinkMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FolderLinkMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "url":
                        value.Url = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "link_permissions":
                        value.LinkPermissions = Dropbox.Api.Sharing.LinkPermissions.Decoder.Decode(reader);
                        break;
                    case "id":
                        value.Id = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "expires":
                        value.Expires = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "path_lower":
                        value.PathLower = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "team_member_info":
                        value.TeamMemberInfo = Dropbox.Api.Sharing.TeamMemberInfo.Decoder.Decode(reader);
                        break;
                    case "content_owner_team_info":
                        value.ContentOwnerTeamInfo = Dropbox.Api.Users.Team.Decoder.Decode(reader);
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
