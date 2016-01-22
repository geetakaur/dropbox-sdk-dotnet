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
    /// <para>The groups list arg object</para>
    /// </summary>
    public class GroupsListArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupsListArg> Encoder = new GroupsListArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupsListArg> Decoder = new GroupsListArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupsListArg" /> class.</para>
        /// </summary>
        /// <param name="limit">Number of results to return per call.</param>
        public GroupsListArg(uint limit = 1000)
        {
            if (limit < 1U || limit > 1000U)
            {
                throw new sys.ArgumentOutOfRangeException("limit");
            }

            this.Limit = limit;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupsListArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GroupsListArg()
        {
            this.Limit = 1000;
        }

        /// <summary>
        /// <para>Number of results to return per call.</para>
        /// </summary>
        public uint Limit { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupsListArg" />.</para>
        /// </summary>
        private class GroupsListArgEncoder : enc.StructEncoder<GroupsListArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupsListArg value, enc.IJsonWriter writer)
            {
                WriteProperty("limit", value.Limit, writer, enc.UInt32Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupsListArg" />.</para>
        /// </summary>
        private class GroupsListArgDecoder : enc.StructDecoder<GroupsListArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupsListArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupsListArg Create()
            {
                return new GroupsListArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupsListArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "limit":
                        value.Limit = enc.UInt32Decoder.Instance.Decode(reader);
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
