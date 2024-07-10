// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UseItemScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UseItemScRsp.proto</summary>
  public static partial class UseItemScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for UseItemScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJVc2VJdGVtU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3RvIpYBCgxVc2VJ",
            "dGVtU2NSc3ASEwoLdXNlX2l0ZW1faWQYBiABKA0SHgoLcmV0dXJuX2RhdGEY",
            "BCABKAsyCS5JdGVtTGlzdBIPCgdyZXRjb2RlGAkgASgNEhMKC0dHS0VNTkdH",
            "QkhGGA4gASgEEhYKDnVzZV9pdGVtX2NvdW50GA0gASgNEhMKC09HTUtMTURB",
            "TklHGA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UseItemScRsp), global::EggLink.DanhengServer.Proto.UseItemScRsp.Parser, new[]{ "UseItemId", "ReturnData", "Retcode", "GGKEMNGGBHF", "UseItemCount", "OGMKLMDANIG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UseItemScRsp : pb::IMessage<UseItemScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UseItemScRsp> _parser = new pb::MessageParser<UseItemScRsp>(() => new UseItemScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UseItemScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UseItemScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemScRsp(UseItemScRsp other) : this() {
      useItemId_ = other.useItemId_;
      returnData_ = other.returnData_ != null ? other.returnData_.Clone() : null;
      retcode_ = other.retcode_;
      gGKEMNGGBHF_ = other.gGKEMNGGBHF_;
      useItemCount_ = other.useItemCount_;
      oGMKLMDANIG_ = other.oGMKLMDANIG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemScRsp Clone() {
      return new UseItemScRsp(this);
    }

    /// <summary>Field number for the "use_item_id" field.</summary>
    public const int UseItemIdFieldNumber = 6;
    private uint useItemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UseItemId {
      get { return useItemId_; }
      set {
        useItemId_ = value;
      }
    }

    /// <summary>Field number for the "return_data" field.</summary>
    public const int ReturnDataFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ItemList returnData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList ReturnData {
      get { return returnData_; }
      set {
        returnData_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "GGKEMNGGBHF" field.</summary>
    public const int GGKEMNGGBHFFieldNumber = 14;
    private ulong gGKEMNGGBHF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong GGKEMNGGBHF {
      get { return gGKEMNGGBHF_; }
      set {
        gGKEMNGGBHF_ = value;
      }
    }

    /// <summary>Field number for the "use_item_count" field.</summary>
    public const int UseItemCountFieldNumber = 13;
    private uint useItemCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UseItemCount {
      get { return useItemCount_; }
      set {
        useItemCount_ = value;
      }
    }

    /// <summary>Field number for the "OGMKLMDANIG" field.</summary>
    public const int OGMKLMDANIGFieldNumber = 15;
    private uint oGMKLMDANIG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OGMKLMDANIG {
      get { return oGMKLMDANIG_; }
      set {
        oGMKLMDANIG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UseItemScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UseItemScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UseItemId != other.UseItemId) return false;
      if (!object.Equals(ReturnData, other.ReturnData)) return false;
      if (Retcode != other.Retcode) return false;
      if (GGKEMNGGBHF != other.GGKEMNGGBHF) return false;
      if (UseItemCount != other.UseItemCount) return false;
      if (OGMKLMDANIG != other.OGMKLMDANIG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UseItemId != 0) hash ^= UseItemId.GetHashCode();
      if (returnData_ != null) hash ^= ReturnData.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (GGKEMNGGBHF != 0UL) hash ^= GGKEMNGGBHF.GetHashCode();
      if (UseItemCount != 0) hash ^= UseItemCount.GetHashCode();
      if (OGMKLMDANIG != 0) hash ^= OGMKLMDANIG.GetHashCode();
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
      if (returnData_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ReturnData);
      }
      if (UseItemId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(UseItemId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      if (UseItemCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(UseItemCount);
      }
      if (GGKEMNGGBHF != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(GGKEMNGGBHF);
      }
      if (OGMKLMDANIG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OGMKLMDANIG);
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
      if (returnData_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ReturnData);
      }
      if (UseItemId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(UseItemId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      if (UseItemCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(UseItemCount);
      }
      if (GGKEMNGGBHF != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(GGKEMNGGBHF);
      }
      if (OGMKLMDANIG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OGMKLMDANIG);
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
      if (UseItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UseItemId);
      }
      if (returnData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReturnData);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (GGKEMNGGBHF != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(GGKEMNGGBHF);
      }
      if (UseItemCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UseItemCount);
      }
      if (OGMKLMDANIG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OGMKLMDANIG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UseItemScRsp other) {
      if (other == null) {
        return;
      }
      if (other.UseItemId != 0) {
        UseItemId = other.UseItemId;
      }
      if (other.returnData_ != null) {
        if (returnData_ == null) {
          ReturnData = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        ReturnData.MergeFrom(other.ReturnData);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.GGKEMNGGBHF != 0UL) {
        GGKEMNGGBHF = other.GGKEMNGGBHF;
      }
      if (other.UseItemCount != 0) {
        UseItemCount = other.UseItemCount;
      }
      if (other.OGMKLMDANIG != 0) {
        OGMKLMDANIG = other.OGMKLMDANIG;
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
          case 34: {
            if (returnData_ == null) {
              ReturnData = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ReturnData);
            break;
          }
          case 48: {
            UseItemId = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 104: {
            UseItemCount = input.ReadUInt32();
            break;
          }
          case 112: {
            GGKEMNGGBHF = input.ReadUInt64();
            break;
          }
          case 120: {
            OGMKLMDANIG = input.ReadUInt32();
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
          case 34: {
            if (returnData_ == null) {
              ReturnData = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ReturnData);
            break;
          }
          case 48: {
            UseItemId = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 104: {
            UseItemCount = input.ReadUInt32();
            break;
          }
          case 112: {
            GGKEMNGGBHF = input.ReadUInt64();
            break;
          }
          case 120: {
            OGMKLMDANIG = input.ReadUInt32();
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