// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PunkLordBattleReplay.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PunkLordBattleReplay.proto</summary>
  public static partial class PunkLordBattleReplayReflection {

    #region Descriptor
    /// <summary>File descriptor for PunkLordBattleReplay.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PunkLordBattleReplayReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQdW5rTG9yZEJhdHRsZVJlcGxheS5wcm90bxoQUmVwbGF5SW5mby5wcm90",
            "byJmChRQdW5rTG9yZEJhdHRsZVJlcGxheRIiChpCYXR0bGVSZXBsYXlLZXlG",
            "aWVsZE51bWJlchgBIAEoCRIqChVSZXBsYXlJbmZvRmllbGROdW1iZXIYAiAB",
            "KAsyCy5SZXBsYXlJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ReplayInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PunkLordBattleReplay), global::EggLink.DanhengServer.Proto.PunkLordBattleReplay.Parser, new[]{ "BattleReplayKeyFieldNumber", "ReplayInfoFieldNumber" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PunkLordBattleReplay : pb::IMessage<PunkLordBattleReplay>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PunkLordBattleReplay> _parser = new pb::MessageParser<PunkLordBattleReplay>(() => new PunkLordBattleReplay());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PunkLordBattleReplay> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PunkLordBattleReplayReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PunkLordBattleReplay() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PunkLordBattleReplay(PunkLordBattleReplay other) : this() {
      battleReplayKeyFieldNumber_ = other.battleReplayKeyFieldNumber_;
      replayInfoFieldNumber_ = other.replayInfoFieldNumber_ != null ? other.replayInfoFieldNumber_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PunkLordBattleReplay Clone() {
      return new PunkLordBattleReplay(this);
    }

    /// <summary>Field number for the "BattleReplayKeyFieldNumber" field.</summary>
    public const int BattleReplayKeyFieldNumberFieldNumber = 1;
    private string battleReplayKeyFieldNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BattleReplayKeyFieldNumber {
      get { return battleReplayKeyFieldNumber_; }
      set {
        battleReplayKeyFieldNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ReplayInfoFieldNumber" field.</summary>
    public const int ReplayInfoFieldNumberFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.ReplayInfo replayInfoFieldNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ReplayInfo ReplayInfoFieldNumber {
      get { return replayInfoFieldNumber_; }
      set {
        replayInfoFieldNumber_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PunkLordBattleReplay);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PunkLordBattleReplay other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BattleReplayKeyFieldNumber != other.BattleReplayKeyFieldNumber) return false;
      if (!object.Equals(ReplayInfoFieldNumber, other.ReplayInfoFieldNumber)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BattleReplayKeyFieldNumber.Length != 0) hash ^= BattleReplayKeyFieldNumber.GetHashCode();
      if (replayInfoFieldNumber_ != null) hash ^= ReplayInfoFieldNumber.GetHashCode();
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
      if (BattleReplayKeyFieldNumber.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BattleReplayKeyFieldNumber);
      }
      if (replayInfoFieldNumber_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ReplayInfoFieldNumber);
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
      if (BattleReplayKeyFieldNumber.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BattleReplayKeyFieldNumber);
      }
      if (replayInfoFieldNumber_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ReplayInfoFieldNumber);
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
      if (BattleReplayKeyFieldNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BattleReplayKeyFieldNumber);
      }
      if (replayInfoFieldNumber_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReplayInfoFieldNumber);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PunkLordBattleReplay other) {
      if (other == null) {
        return;
      }
      if (other.BattleReplayKeyFieldNumber.Length != 0) {
        BattleReplayKeyFieldNumber = other.BattleReplayKeyFieldNumber;
      }
      if (other.replayInfoFieldNumber_ != null) {
        if (replayInfoFieldNumber_ == null) {
          ReplayInfoFieldNumber = new global::EggLink.DanhengServer.Proto.ReplayInfo();
        }
        ReplayInfoFieldNumber.MergeFrom(other.ReplayInfoFieldNumber);
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
            BattleReplayKeyFieldNumber = input.ReadString();
            break;
          }
          case 18: {
            if (replayInfoFieldNumber_ == null) {
              ReplayInfoFieldNumber = new global::EggLink.DanhengServer.Proto.ReplayInfo();
            }
            input.ReadMessage(ReplayInfoFieldNumber);
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
            BattleReplayKeyFieldNumber = input.ReadString();
            break;
          }
          case 18: {
            if (replayInfoFieldNumber_ == null) {
              ReplayInfoFieldNumber = new global::EggLink.DanhengServer.Proto.ReplayInfo();
            }
            input.ReadMessage(ReplayInfoFieldNumber);
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