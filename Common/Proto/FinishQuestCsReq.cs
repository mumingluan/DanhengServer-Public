// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FinishQuestCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FinishQuestCsReq.proto</summary>
  public static partial class FinishQuestCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FinishQuestCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FinishQuestCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGaW5pc2hRdWVzdENzUmVxLnByb3RvIkoKEEZpbmlzaFF1ZXN0Q3NSZXES",
            "EAoIZ3JvdXBfaWQYCSABKA0SEwoLRktIT0hBSUJJRUEYBSABKA0SDwoHcHJv",
            "cF9pZBgNIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FinishQuestCsReq), global::EggLink.DanhengServer.Proto.FinishQuestCsReq.Parser, new[]{ "GroupId", "FKHOHAIBIEA", "PropId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FinishQuestCsReq : pb::IMessage<FinishQuestCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FinishQuestCsReq> _parser = new pb::MessageParser<FinishQuestCsReq>(() => new FinishQuestCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FinishQuestCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FinishQuestCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishQuestCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishQuestCsReq(FinishQuestCsReq other) : this() {
      groupId_ = other.groupId_;
      fKHOHAIBIEA_ = other.fKHOHAIBIEA_;
      propId_ = other.propId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishQuestCsReq Clone() {
      return new FinishQuestCsReq(this);
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 9;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "FKHOHAIBIEA" field.</summary>
    public const int FKHOHAIBIEAFieldNumber = 5;
    private uint fKHOHAIBIEA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FKHOHAIBIEA {
      get { return fKHOHAIBIEA_; }
      set {
        fKHOHAIBIEA_ = value;
      }
    }

    /// <summary>Field number for the "prop_id" field.</summary>
    public const int PropIdFieldNumber = 13;
    private uint propId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropId {
      get { return propId_; }
      set {
        propId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FinishQuestCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FinishQuestCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupId != other.GroupId) return false;
      if (FKHOHAIBIEA != other.FKHOHAIBIEA) return false;
      if (PropId != other.PropId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (FKHOHAIBIEA != 0) hash ^= FKHOHAIBIEA.GetHashCode();
      if (PropId != 0) hash ^= PropId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (FKHOHAIBIEA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FKHOHAIBIEA);
      }
      if (GroupId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GroupId);
      }
      if (PropId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PropId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FKHOHAIBIEA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FKHOHAIBIEA);
      }
      if (GroupId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GroupId);
      }
      if (PropId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PropId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (FKHOHAIBIEA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FKHOHAIBIEA);
      }
      if (PropId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FinishQuestCsReq other) {
      if (other == null) {
        return;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.FKHOHAIBIEA != 0) {
        FKHOHAIBIEA = other.FKHOHAIBIEA;
      }
      if (other.PropId != 0) {
        PropId = other.PropId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 40: {
            FKHOHAIBIEA = input.ReadUInt32();
            break;
          }
          case 72: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 104: {
            PropId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 40: {
            FKHOHAIBIEA = input.ReadUInt32();
            break;
          }
          case 72: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 104: {
            PropId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code