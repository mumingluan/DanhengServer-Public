// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueLineupInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueLineupInfo.proto</summary>
  public static partial class ChessRogueLineupInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueLineupInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueLineupInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpDaGVzc1JvZ3VlTGluZXVwSW5mby5wcm90bxogQ2hlc3NSb2d1ZUxpbmV1",
            "cEF2YXRhckluZm8ucHJvdG8aEUlCSEZJR0RIRUxPLnByb3RvInEKFENoZXNz",
            "Um9ndWVMaW5ldXBJbmZvEjYKEWNoZXNzX2F2YXRhcl9saXN0GAEgAygLMhsu",
            "Q2hlc3NSb2d1ZUxpbmV1cEF2YXRhckluZm8SIQoLcmV2aXZlX2luZm8YBiAB",
            "KAsyDC5JQkhGSUdESEVMT0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueLineupAvatarInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.IBHFIGDHELOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueLineupInfo), global::EggLink.DanhengServer.Proto.ChessRogueLineupInfo.Parser, new[]{ "ChessAvatarList", "ReviveInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueLineupInfo : pb::IMessage<ChessRogueLineupInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueLineupInfo> _parser = new pb::MessageParser<ChessRogueLineupInfo>(() => new ChessRogueLineupInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueLineupInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueLineupInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueLineupInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueLineupInfo(ChessRogueLineupInfo other) : this() {
      chessAvatarList_ = other.chessAvatarList_.Clone();
      reviveInfo_ = other.reviveInfo_ != null ? other.reviveInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueLineupInfo Clone() {
      return new ChessRogueLineupInfo(this);
    }

    /// <summary>Field number for the "chess_avatar_list" field.</summary>
    public const int ChessAvatarListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChessRogueLineupAvatarInfo> _repeated_chessAvatarList_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.ChessRogueLineupAvatarInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueLineupAvatarInfo> chessAvatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueLineupAvatarInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueLineupAvatarInfo> ChessAvatarList {
      get { return chessAvatarList_; }
    }

    /// <summary>Field number for the "revive_info" field.</summary>
    public const int ReviveInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.IBHFIGDHELO reviveInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IBHFIGDHELO ReviveInfo {
      get { return reviveInfo_; }
      set {
        reviveInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueLineupInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueLineupInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!chessAvatarList_.Equals(other.chessAvatarList_)) return false;
      if (!object.Equals(ReviveInfo, other.ReviveInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= chessAvatarList_.GetHashCode();
      if (reviveInfo_ != null) hash ^= ReviveInfo.GetHashCode();
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
      chessAvatarList_.WriteTo(output, _repeated_chessAvatarList_codec);
      if (reviveInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ReviveInfo);
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
      chessAvatarList_.WriteTo(ref output, _repeated_chessAvatarList_codec);
      if (reviveInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ReviveInfo);
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
      size += chessAvatarList_.CalculateSize(_repeated_chessAvatarList_codec);
      if (reviveInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReviveInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueLineupInfo other) {
      if (other == null) {
        return;
      }
      chessAvatarList_.Add(other.chessAvatarList_);
      if (other.reviveInfo_ != null) {
        if (reviveInfo_ == null) {
          ReviveInfo = new global::EggLink.DanhengServer.Proto.IBHFIGDHELO();
        }
        ReviveInfo.MergeFrom(other.ReviveInfo);
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
          case 10: {
            chessAvatarList_.AddEntriesFrom(input, _repeated_chessAvatarList_codec);
            break;
          }
          case 50: {
            if (reviveInfo_ == null) {
              ReviveInfo = new global::EggLink.DanhengServer.Proto.IBHFIGDHELO();
            }
            input.ReadMessage(ReviveInfo);
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
          case 10: {
            chessAvatarList_.AddEntriesFrom(ref input, _repeated_chessAvatarList_codec);
            break;
          }
          case 50: {
            if (reviveInfo_ == null) {
              ReviveInfo = new global::EggLink.DanhengServer.Proto.IBHFIGDHELO();
            }
            input.ReadMessage(ReviveInfo);
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