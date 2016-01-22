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
    /// <para>The member add arg object</para>
    /// </summary>
    public class MemberAddArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberAddArg> Encoder = new MemberAddArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberAddArg> Decoder = new MemberAddArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberAddArg" /> class.</para>
        /// </summary>
        /// <param name="memberEmail">The member email</param>
        /// <param name="memberGivenName">Member's first name.</param>
        /// <param name="memberSurname">Member's last name.</param>
        /// <param name="memberExternalId">External ID for member.</param>
        /// <param name="sendWelcomeEmail">Whether to send a welcome email to the member. If
        /// send_welcome_email is false, no email invitation will be sent to the user. This may
        /// be useful for apps using single sign-on (SSO) flows for onboarding that want to
        /// handle announcements themselves.</param>
        /// <param name="role">The role</param>
        public MemberAddArg(string memberEmail,
                            string memberGivenName,
                            string memberSurname,
                            string memberExternalId = null,
                            bool sendWelcomeEmail = true,
                            AdminTier role = null)
        {
            if (memberEmail == null)
            {
                throw new sys.ArgumentNullException("memberEmail");
            }
            else if (!re.Regex.IsMatch(memberEmail, @"\A(?:^['&A-Za-z0-9._%+-]+@[A-Za-z0-9-][A-Za-z0-9.-]*.[A-Za-z]{2,15}$)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("memberEmail");
            }

            if (memberGivenName == null)
            {
                throw new sys.ArgumentNullException("memberGivenName");
            }
            else if (memberGivenName.Length < 1 || !re.Regex.IsMatch(memberGivenName, @"\A(?:[^/:?*<>""|]*)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("memberGivenName");
            }

            if (memberSurname == null)
            {
                throw new sys.ArgumentNullException("memberSurname");
            }
            else if (memberSurname.Length < 1 || !re.Regex.IsMatch(memberSurname, @"\A(?:[^/:?*<>""|]*)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("memberSurname");
            }

            if (memberExternalId != null && (memberExternalId.Length > 64))
            {
                throw new sys.ArgumentOutOfRangeException("memberExternalId");
            }

            if (role == null)
            {
                role = AdminTier.MemberOnly.Instance;
            }

            this.MemberEmail = memberEmail;
            this.MemberGivenName = memberGivenName;
            this.MemberSurname = memberSurname;
            this.MemberExternalId = memberExternalId;
            this.SendWelcomeEmail = sendWelcomeEmail;
            this.Role = role;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberAddArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public MemberAddArg()
        {
            this.SendWelcomeEmail = true;
            this.Role = AdminTier.MemberOnly.Instance;
        }

        /// <summary>
        /// <para>Gets the member email of the member add arg</para>
        /// </summary>
        public string MemberEmail { get; protected set; }

        /// <summary>
        /// <para>Member's first name.</para>
        /// </summary>
        public string MemberGivenName { get; protected set; }

        /// <summary>
        /// <para>Member's last name.</para>
        /// </summary>
        public string MemberSurname { get; protected set; }

        /// <summary>
        /// <para>External ID for member.</para>
        /// </summary>
        public string MemberExternalId { get; protected set; }

        /// <summary>
        /// <para>Whether to send a welcome email to the member. If send_welcome_email is
        /// false, no email invitation will be sent to the user. This may be useful for apps
        /// using single sign-on (SSO) flows for onboarding that want to handle announcements
        /// themselves.</para>
        /// </summary>
        public bool SendWelcomeEmail { get; protected set; }

        /// <summary>
        /// <para>Gets the role of the member add arg</para>
        /// </summary>
        public AdminTier Role { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberAddArg" />.</para>
        /// </summary>
        private class MemberAddArgEncoder : enc.StructEncoder<MemberAddArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberAddArg value, enc.IJsonWriter writer)
            {
                WriteProperty("member_email", value.MemberEmail, writer, enc.StringEncoder.Instance);
                WriteProperty("member_given_name", value.MemberGivenName, writer, enc.StringEncoder.Instance);
                WriteProperty("member_surname", value.MemberSurname, writer, enc.StringEncoder.Instance);
                if (value.MemberExternalId != null)
                {
                    WriteProperty("member_external_id", value.MemberExternalId, writer, enc.StringEncoder.Instance);
                }
                WriteProperty("send_welcome_email", value.SendWelcomeEmail, writer, enc.BooleanEncoder.Instance);
                WriteProperty("role", value.Role, writer, Dropbox.Api.Team.AdminTier.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberAddArg" />.</para>
        /// </summary>
        private class MemberAddArgDecoder : enc.StructDecoder<MemberAddArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberAddArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberAddArg Create()
            {
                return new MemberAddArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberAddArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "member_email":
                        value.MemberEmail = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_given_name":
                        value.MemberGivenName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_surname":
                        value.MemberSurname = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_external_id":
                        value.MemberExternalId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "send_welcome_email":
                        value.SendWelcomeEmail = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "role":
                        value.Role = Dropbox.Api.Team.AdminTier.Decoder.Decode(reader);
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
