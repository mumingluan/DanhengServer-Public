// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneBattleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneBattleInfo.proto</summary>
  public static partial class SceneBattleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneBattleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneBattleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTY2VuZUJhdHRsZUluZm8ucHJvdG8aEkJhdHRsZUF2YXRhci5wcm90bxob",
            "RXZvbHZlQnVpbGRCYXR0bGVJbmZvLnByb3RvGhFMTklGTkNBTElPTS5wcm90",
            "bxoWQmF0dGxlVGFyZ2V0TGlzdC5wcm90bxoWU2NlbmVNb25zdGVyV2F2ZS5w",
            "cm90bxobQmF0dGxlRXZlbnRCYXR0bGVJbmZvLnByb3RvGhBCYXR0bGVCdWZm",
            "LnByb3RvIrEECg9TY2VuZUJhdHRsZUluZm8SLAoRbW9uc3Rlcl93YXZlX2xp",
            "c3QYByADKAsyES5TY2VuZU1vbnN0ZXJXYXZlEkMKEmJhdHRsZV90YXJnZXRf",
            "aW5mbxjHBCADKAsyJi5TY2VuZUJhdHRsZUluZm8uQmF0dGxlVGFyZ2V0SW5m",
            "b0VudHJ5EhEKCWJhdHRsZV9pZBgPIAEoDRITCgt3b3JsZF9sZXZlbBgBIAEo",
            "DRIeCglidWZmX2xpc3QYBiADKAsyCy5CYXR0bGVCdWZmEhMKC0JHSEdMR0dQ",
            "QkdBGAogASgNEiIKC05IT0tISkdLS0xPGMQMIAEoCzIMLkxOSUZOQ0FMSU9N",
            "EiwKC09KTEJCSEdHRkpIGNEBIAEoCzIWLkV2b2x2ZUJ1aWxkQmF0dGxlSW5m",
            "bxIUCgxyb3VuZHNfbGltaXQYCCABKA0SGQoRbG9naWNfcmFuZG9tX3NlZWQY",
            "AyABKA0SKQoSYXZhdGFyX2JhdHRsZV9saXN0GAQgAygLMg0uQmF0dGxlQXZh",
            "dGFyEhMKC0ZDTkVGTkVGR0RBGA4gASgIEi0KDGJhdHRsZV9ldmVudBidAyAD",
            "KAsyFi5CYXR0bGVFdmVudEJhdHRsZUluZm8SEAoIc3RhZ2VfaWQYCyABKA0a",
            "SgoVQmF0dGxlVGFyZ2V0SW5mb0VudHJ5EgsKA2tleRgBIAEoDRIgCgV2YWx1",
            "ZRgCIAEoCzIRLkJhdHRsZVRhcmdldExpc3Q6AjgBQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BattleAvatarReflection.Descriptor, global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.LNIFNCALIOMReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleTargetListReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneMonsterWaveReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleEventBattleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneBattleInfo), global::EggLink.DanhengServer.Proto.SceneBattleInfo.Parser, new[]{ "MonsterWaveList", "BattleTargetInfo", "BattleId", "WorldLevel", "BuffList", "BGHGLGGPBGA", "NHOKHJGKKLO", "OJLBBHGGFJH", "RoundsLimit", "LogicRandomSeed", "AvatarBattleList", "FCNEFNEFGDA", "BattleEvent", "StageId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneBattleInfo : pb::IMessage<SceneBattleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneBattleInfo> _parser = new pb::MessageParser<SceneBattleInfo>(() => new SceneBattleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneBattleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneBattleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneBattleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneBattleInfo(SceneBattleInfo other) : this() {
      monsterWaveList_ = other.monsterWaveList_.Clone();
      battleTargetInfo_ = other.battleTargetInfo_.Clone();
      battleId_ = other.battleId_;
      worldLevel_ = other.worldLevel_;
      buffList_ = other.buffList_.Clone();
      bGHGLGGPBGA_ = other.bGHGLGGPBGA_;
      nHOKHJGKKLO_ = other.nHOKHJGKKLO_ != null ? other.nHOKHJGKKLO_.Clone() : null;
      oJLBBHGGFJH_ = other.oJLBBHGGFJH_ != null ? other.oJLBBHGGFJH_.Clone() : null;
      roundsLimit_ = other.roundsLimit_;
      logicRandomSeed_ = other.logicRandomSeed_;
      avatarBattleList_ = other.avatarBattleList_.Clone();
      fCNEFNEFGDA_ = other.fCNEFNEFGDA_;
      battleEvent_ = other.battleEvent_.Clone();
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneBattleInfo Clone() {
      return new SceneBattleInfo(this);
    }

    /// <summary>Field number for the "monster_wave_list" field.</summary>
    public const int MonsterWaveListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneMonsterWave> _repeated_monsterWaveList_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.SceneMonsterWave.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonsterWave> monsterWaveList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonsterWave>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonsterWave> MonsterWaveList {
      get { return monsterWaveList_; }
    }

    /// <summary>Field number for the "battle_target_info" field.</summary>
    public const int BattleTargetInfoFieldNumber = 583;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList>.Codec _map_battleTargetInfo_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.BattleTargetList.Parser), 4666);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList> battleTargetInfo_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList> BattleTargetInfo {
      get { return battleTargetInfo_; }
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 15;
    private uint battleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleId {
      get { return battleId_; }
      set {
        battleId_ = value;
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 1;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "buff_list" field.</summary>
    public const int BuffListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleBuff> _repeated_buffList_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.BattleBuff.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleBuff> buffList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleBuff> BuffList {
      get { return buffList_; }
    }

    /// <summary>Field number for the "BGHGLGGPBGA" field.</summary>
    public const int BGHGLGGPBGAFieldNumber = 10;
    private uint bGHGLGGPBGA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BGHGLGGPBGA {
      get { return bGHGLGGPBGA_; }
      set {
        bGHGLGGPBGA_ = value;
      }
    }

    /// <summary>Field number for the "NHOKHJGKKLO" field.</summary>
    public const int NHOKHJGKKLOFieldNumber = 1604;
    private global::EggLink.DanhengServer.Proto.LNIFNCALIOM nHOKHJGKKLO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LNIFNCALIOM NHOKHJGKKLO {
      get { return nHOKHJGKKLO_; }
      set {
        nHOKHJGKKLO_ = value;
      }
    }

    /// <summary>Field number for the "OJLBBHGGFJH" field.</summary>
    public const int OJLBBHGGFJHFieldNumber = 209;
    private global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfo oJLBBHGGFJH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfo OJLBBHGGFJH {
      get { return oJLBBHGGFJH_; }
      set {
        oJLBBHGGFJH_ = value;
      }
    }

    /// <summary>Field number for the "rounds_limit" field.</summary>
    public const int RoundsLimitFieldNumber = 8;
    private uint roundsLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoundsLimit {
      get { return roundsLimit_; }
      set {
        roundsLimit_ = value;
      }
    }

    /// <summary>Field number for the "logic_random_seed" field.</summary>
    public const int LogicRandomSeedFieldNumber = 3;
    private uint logicRandomSeed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LogicRandomSeed {
      get { return logicRandomSeed_; }
      set {
        logicRandomSeed_ = value;
      }
    }

    /// <summary>Field number for the "avatar_battle_list" field.</summary>
    public const int AvatarBattleListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleAvatar> _repeated_avatarBattleList_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.BattleAvatar.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar> avatarBattleList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar> AvatarBattleList {
      get { return avatarBattleList_; }
    }

    /// <summary>Field number for the "FCNEFNEFGDA" field.</summary>
    public const int FCNEFNEFGDAFieldNumber = 14;
    private bool fCNEFNEFGDA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FCNEFNEFGDA {
      get { return fCNEFNEFGDA_; }
      set {
        fCNEFNEFGDA_ = value;
      }
    }

    /// <summary>Field number for the "battle_event" field.</summary>
    public const int BattleEventFieldNumber = 413;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo> _repeated_battleEvent_codec
        = pb::FieldCodec.ForMessage(3306, global::EggLink.DanhengServer.Proto.BattleEventBattleInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo> battleEvent_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo> BattleEvent {
      get { return battleEvent_; }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 11;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneBattleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneBattleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!monsterWaveList_.Equals(other.monsterWaveList_)) return false;
      if (!BattleTargetInfo.Equals(other.BattleTargetInfo)) return false;
      if (BattleId != other.BattleId) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if(!buffList_.Equals(other.buffList_)) return false;
      if (BGHGLGGPBGA != other.BGHGLGGPBGA) return false;
      if (!object.Equals(NHOKHJGKKLO, other.NHOKHJGKKLO)) return false;
      if (!object.Equals(OJLBBHGGFJH, other.OJLBBHGGFJH)) return false;
      if (RoundsLimit != other.RoundsLimit) return false;
      if (LogicRandomSeed != other.LogicRandomSeed) return false;
      if(!avatarBattleList_.Equals(other.avatarBattleList_)) return false;
      if (FCNEFNEFGDA != other.FCNEFNEFGDA) return false;
      if(!battleEvent_.Equals(other.battleEvent_)) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= monsterWaveList_.GetHashCode();
      hash ^= BattleTargetInfo.GetHashCode();
      if (BattleId != 0) hash ^= BattleId.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      hash ^= buffList_.GetHashCode();
      if (BGHGLGGPBGA != 0) hash ^= BGHGLGGPBGA.GetHashCode();
      if (nHOKHJGKKLO_ != null) hash ^= NHOKHJGKKLO.GetHashCode();
      if (oJLBBHGGFJH_ != null) hash ^= OJLBBHGGFJH.GetHashCode();
      if (RoundsLimit != 0) hash ^= RoundsLimit.GetHashCode();
      if (LogicRandomSeed != 0) hash ^= LogicRandomSeed.GetHashCode();
      hash ^= avatarBattleList_.GetHashCode();
      if (FCNEFNEFGDA != false) hash ^= FCNEFNEFGDA.GetHashCode();
      hash ^= battleEvent_.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
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
      if (WorldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldLevel);
      }
      if (LogicRandomSeed != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(LogicRandomSeed);
      }
      avatarBattleList_.WriteTo(output, _repeated_avatarBattleList_codec);
      buffList_.WriteTo(output, _repeated_buffList_codec);
      monsterWaveList_.WriteTo(output, _repeated_monsterWaveList_codec);
      if (RoundsLimit != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RoundsLimit);
      }
      if (BGHGLGGPBGA != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BGHGLGGPBGA);
      }
      if (StageId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(StageId);
      }
      if (FCNEFNEFGDA != false) {
        output.WriteRawTag(112);
        output.WriteBool(FCNEFNEFGDA);
      }
      if (BattleId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BattleId);
      }
      if (oJLBBHGGFJH_ != null) {
        output.WriteRawTag(138, 13);
        output.WriteMessage(OJLBBHGGFJH);
      }
      battleEvent_.WriteTo(output, _repeated_battleEvent_codec);
      battleTargetInfo_.WriteTo(output, _map_battleTargetInfo_codec);
      if (nHOKHJGKKLO_ != null) {
        output.WriteRawTag(162, 100);
        output.WriteMessage(NHOKHJGKKLO);
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
      if (WorldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldLevel);
      }
      if (LogicRandomSeed != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(LogicRandomSeed);
      }
      avatarBattleList_.WriteTo(ref output, _repeated_avatarBattleList_codec);
      buffList_.WriteTo(ref output, _repeated_buffList_codec);
      monsterWaveList_.WriteTo(ref output, _repeated_monsterWaveList_codec);
      if (RoundsLimit != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RoundsLimit);
      }
      if (BGHGLGGPBGA != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BGHGLGGPBGA);
      }
      if (StageId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(StageId);
      }
      if (FCNEFNEFGDA != false) {
        output.WriteRawTag(112);
        output.WriteBool(FCNEFNEFGDA);
      }
      if (BattleId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BattleId);
      }
      if (oJLBBHGGFJH_ != null) {
        output.WriteRawTag(138, 13);
        output.WriteMessage(OJLBBHGGFJH);
      }
      battleEvent_.WriteTo(ref output, _repeated_battleEvent_codec);
      battleTargetInfo_.WriteTo(ref output, _map_battleTargetInfo_codec);
      if (nHOKHJGKKLO_ != null) {
        output.WriteRawTag(162, 100);
        output.WriteMessage(NHOKHJGKKLO);
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
      size += monsterWaveList_.CalculateSize(_repeated_monsterWaveList_codec);
      size += battleTargetInfo_.CalculateSize(_map_battleTargetInfo_codec);
      if (BattleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleId);
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      size += buffList_.CalculateSize(_repeated_buffList_codec);
      if (BGHGLGGPBGA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BGHGLGGPBGA);
      }
      if (nHOKHJGKKLO_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(NHOKHJGKKLO);
      }
      if (oJLBBHGGFJH_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(OJLBBHGGFJH);
      }
      if (RoundsLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoundsLimit);
      }
      if (LogicRandomSeed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LogicRandomSeed);
      }
      size += avatarBattleList_.CalculateSize(_repeated_avatarBattleList_codec);
      if (FCNEFNEFGDA != false) {
        size += 1 + 1;
      }
      size += battleEvent_.CalculateSize(_repeated_battleEvent_codec);
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneBattleInfo other) {
      if (other == null) {
        return;
      }
      monsterWaveList_.Add(other.monsterWaveList_);
      battleTargetInfo_.MergeFrom(other.battleTargetInfo_);
      if (other.BattleId != 0) {
        BattleId = other.BattleId;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      buffList_.Add(other.buffList_);
      if (other.BGHGLGGPBGA != 0) {
        BGHGLGGPBGA = other.BGHGLGGPBGA;
      }
      if (other.nHOKHJGKKLO_ != null) {
        if (nHOKHJGKKLO_ == null) {
          NHOKHJGKKLO = new global::EggLink.DanhengServer.Proto.LNIFNCALIOM();
        }
        NHOKHJGKKLO.MergeFrom(other.NHOKHJGKKLO);
      }
      if (other.oJLBBHGGFJH_ != null) {
        if (oJLBBHGGFJH_ == null) {
          OJLBBHGGFJH = new global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfo();
        }
        OJLBBHGGFJH.MergeFrom(other.OJLBBHGGFJH);
      }
      if (other.RoundsLimit != 0) {
        RoundsLimit = other.RoundsLimit;
      }
      if (other.LogicRandomSeed != 0) {
        LogicRandomSeed = other.LogicRandomSeed;
      }
      avatarBattleList_.Add(other.avatarBattleList_);
      if (other.FCNEFNEFGDA != false) {
        FCNEFNEFGDA = other.FCNEFNEFGDA;
      }
      battleEvent_.Add(other.battleEvent_);
      if (other.StageId != 0) {
        StageId = other.StageId;
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
          case 8: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            LogicRandomSeed = input.ReadUInt32();
            break;
          }
          case 34: {
            avatarBattleList_.AddEntriesFrom(input, _repeated_avatarBattleList_codec);
            break;
          }
          case 50: {
            buffList_.AddEntriesFrom(input, _repeated_buffList_codec);
            break;
          }
          case 58: {
            monsterWaveList_.AddEntriesFrom(input, _repeated_monsterWaveList_codec);
            break;
          }
          case 64: {
            RoundsLimit = input.ReadUInt32();
            break;
          }
          case 80: {
            BGHGLGGPBGA = input.ReadUInt32();
            break;
          }
          case 88: {
            StageId = input.ReadUInt32();
            break;
          }
          case 112: {
            FCNEFNEFGDA = input.ReadBool();
            break;
          }
          case 120: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 1674: {
            if (oJLBBHGGFJH_ == null) {
              OJLBBHGGFJH = new global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfo();
            }
            input.ReadMessage(OJLBBHGGFJH);
            break;
          }
          case 3306: {
            battleEvent_.AddEntriesFrom(input, _repeated_battleEvent_codec);
            break;
          }
          case 4666: {
            battleTargetInfo_.AddEntriesFrom(input, _map_battleTargetInfo_codec);
            break;
          }
          case 12834: {
            if (nHOKHJGKKLO_ == null) {
              NHOKHJGKKLO = new global::EggLink.DanhengServer.Proto.LNIFNCALIOM();
            }
            input.ReadMessage(NHOKHJGKKLO);
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
          case 8: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            LogicRandomSeed = input.ReadUInt32();
            break;
          }
          case 34: {
            avatarBattleList_.AddEntriesFrom(ref input, _repeated_avatarBattleList_codec);
            break;
          }
          case 50: {
            buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
            break;
          }
          case 58: {
            monsterWaveList_.AddEntriesFrom(ref input, _repeated_monsterWaveList_codec);
            break;
          }
          case 64: {
            RoundsLimit = input.ReadUInt32();
            break;
          }
          case 80: {
            BGHGLGGPBGA = input.ReadUInt32();
            break;
          }
          case 88: {
            StageId = input.ReadUInt32();
            break;
          }
          case 112: {
            FCNEFNEFGDA = input.ReadBool();
            break;
          }
          case 120: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 1674: {
            if (oJLBBHGGFJH_ == null) {
              OJLBBHGGFJH = new global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfo();
            }
            input.ReadMessage(OJLBBHGGFJH);
            break;
          }
          case 3306: {
            battleEvent_.AddEntriesFrom(ref input, _repeated_battleEvent_codec);
            break;
          }
          case 4666: {
            battleTargetInfo_.AddEntriesFrom(ref input, _map_battleTargetInfo_codec);
            break;
          }
          case 12834: {
            if (nHOKHJGKKLO_ == null) {
              NHOKHJGKKLO = new global::EggLink.DanhengServer.Proto.LNIFNCALIOM();
            }
            input.ReadMessage(NHOKHJGKKLO);
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