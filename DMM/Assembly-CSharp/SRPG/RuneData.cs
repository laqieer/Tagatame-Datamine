// Decompiled with JetBrains decompiler
// Type: SRPG.RuneData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010F6")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneData
  {
    [Token(Token = "0x4003D45")]
    [FieldOffset(Offset = "0x8")]
    public OLong mUniqueID;
    [Token(Token = "0x4003D46")]
    [FieldOffset(Offset = "0x30")]
    public string iname;
    [Token(Token = "0x4003D47")]
    [FieldOffset(Offset = "0x34")]
    public int unit_id;
    [Token(Token = "0x4003D48")]
    [FieldOffset(Offset = "0x38")]
    public byte enforce;
    [Token(Token = "0x4003D49")]
    [FieldOffset(Offset = "0x39")]
    public byte evo;
    [Token(Token = "0x4003D4A")]
    [FieldOffset(Offset = "0x3A")]
    private byte slot_index;
    [Token(Token = "0x4003D4B")]
    [FieldOffset(Offset = "0x3B")]
    private bool favorite;
    [Token(Token = "0x4003D4C")]
    [FieldOffset(Offset = "0x3C")]
    public RuneStateData state;
    [Token(Token = "0x4003D4D")]
    [FieldOffset(Offset = "0x40")]
    private bool isDisassembly;

    [Token(Token = "0x60047BC")]
    [Address(RVA = "0x11EEBB0", Offset = "0x11ED9B0", VA = "0x111EEBB0")]
    public bool Deserialize(Json_RuneData json) => new bool();

    [Token(Token = "0x60047BD")]
    [Address(RVA = "0x11F0BC0", Offset = "0x11EF9C0", VA = "0x111F0BC0")]
    public Json_RuneData Serialize() => (Json_RuneData) null;

    [Token(Token = "0x1700075B")]
    [IgnoreMember]
    public OLong UniqueID
    {
      [Token(Token = "0x60047BE"), Address(RVA = "0x305BB0", Offset = "0x3049B0", VA = "0x10305BB0")] get
      {
        return new OLong();
      }
    }

    [Token(Token = "0x1700075C")]
    [IgnoreMember]
    public RuneParam RuneParam
    {
      [Token(Token = "0x60047BF"), Address(RVA = "0x11F13C0", Offset = "0x11F01C0", VA = "0x111F13C0")] get
      {
        return (RuneParam) null;
      }
    }

    [Token(Token = "0x1700075D")]
    [IgnoreMember]
    public RuneMaterial RuneMaterialList
    {
      [Token(Token = "0x60047C0"), Address(RVA = "0x11F1290", Offset = "0x11F0090", VA = "0x111F1290")] get
      {
        return (RuneMaterial) null;
      }
    }

    [Token(Token = "0x1700075E")]
    [IgnoreMember]
    public RuneCost EnhanceCost
    {
      [Token(Token = "0x60047C1"), Address(RVA = "0x11F0EC0", Offset = "0x11EFCC0", VA = "0x111F0EC0")] get
      {
        return (RuneCost) null;
      }
    }

    [Token(Token = "0x1700075F")]
    [IgnoreMember]
    public int DisassemblyZeny
    {
      [Token(Token = "0x60047C2"), Address(RVA = "0x11F0EA0", Offset = "0x11EFCA0", VA = "0x111F0EA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000760")]
    [IgnoreMember]
    public RuneCost EvoCost
    {
      [Token(Token = "0x60047C3"), Address(RVA = "0x11F0FB0", Offset = "0x11EFDB0", VA = "0x111F0FB0")] get
      {
        return (RuneCost) null;
      }
    }

    [Token(Token = "0x17000761")]
    [IgnoreMember]
    public RuneCost[] ResetParamBaseCost
    {
      [Token(Token = "0x60047C4"), Address(RVA = "0x11F1230", Offset = "0x11F0030", VA = "0x111F1230")] get
      {
        return (RuneCost[]) null;
      }
    }

    [Token(Token = "0x17000762")]
    [IgnoreMember]
    public RuneCost[] ResetStatusEvoCost
    {
      [Token(Token = "0x60047C5"), Address(RVA = "0x11F1260", Offset = "0x11F0060", VA = "0x111F1260")] get
      {
        return (RuneCost[]) null;
      }
    }

    [Token(Token = "0x17000763")]
    [IgnoreMember]
    public RuneCost[] ParamEnhEvoCost
    {
      [Token(Token = "0x60047C6"), Address(RVA = "0x11F11C0", Offset = "0x11EFFC0", VA = "0x111F11C0")] get
      {
        return (RuneCost[]) null;
      }
    }

    [Token(Token = "0x17000764")]
    [IgnoreMember]
    public RuneMaterial RuneMaterial
    {
      [Token(Token = "0x60047C7"), Address(RVA = "0x11F1340", Offset = "0x11F0140", VA = "0x111F1340")] get
      {
        return (RuneMaterial) null;
      }
    }

    [Token(Token = "0x17000765")]
    [IgnoreMember]
    public UnitData UnitData
    {
      [Token(Token = "0x60047C8"), Address(RVA = "0x11F1480", Offset = "0x11F0280", VA = "0x111F1480")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17000766")]
    [IgnoreMember]
    public int EnhanceNum
    {
      [Token(Token = "0x60047C9"), Address(RVA = "0x11F0F10", Offset = "0x11EFD10", VA = "0x111F0F10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000767")]
    [IgnoreMember]
    public bool IsEvoNext
    {
      [Token(Token = "0x60047CA"), Address(RVA = "0x11F10A0", Offset = "0x11EFEA0", VA = "0x111F10A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000768")]
    [IgnoreMember]
    public bool IsCanEvo
    {
      [Token(Token = "0x60047CB"), Address(RVA = "0x11F1010", Offset = "0x11EFE10", VA = "0x111F1010")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000769")]
    [IgnoreMember]
    public int EvoNum
    {
      [Token(Token = "0x60047CC"), Address(RVA = "0x11F1000", Offset = "0x11EFE00", VA = "0x111F1000")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700076A")]
    [IgnoreMember]
    public ItemParam Item
    {
      [Token(Token = "0x60047CD"), Address(RVA = "0x11F1150", Offset = "0x11EFF50", VA = "0x111F1150")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x1700076B")]
    [IgnoreMember]
    public int Rarity
    {
      [Token(Token = "0x60047CE"), Address(RVA = "0x11F11F0", Offset = "0x11EFFF0", VA = "0x111F11F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700076C")]
    [IgnoreMember]
    public int Slot
    {
      [Token(Token = "0x60047CF"), Address(RVA = "0x11F1420", Offset = "0x11F0220", VA = "0x111F1420")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700076D")]
    [IgnoreMember]
    public bool IsFavorite
    {
      [Token(Token = "0x60047D0"), Address(RVA = "0xAAD940", Offset = "0xAAC740", VA = "0x10AAD940")] get
      {
        return new bool();
      }
      [Token(Token = "0x60047D1"), Address(RVA = "0x11F14E0", Offset = "0x11F02E0", VA = "0x111F14E0")] set
      {
      }
    }

    [Token(Token = "0x1700076E")]
    [IgnoreMember]
    public long DedicatedUnitID
    {
      [Token(Token = "0x60047D2"), Address(RVA = "0x11F0E80", Offset = "0x11EFC80", VA = "0x111F0E80")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700076F")]
    [IgnoreMember]
    public bool IsDedicated
    {
      [Token(Token = "0x60047D3"), Address(RVA = "0x11F1070", Offset = "0x11EFE70", VA = "0x111F1070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000770")]
    [IgnoreMember]
    public bool CanDedicated
    {
      [Token(Token = "0x60047D4"), Address(RVA = "0x11F0D50", Offset = "0x11EFB50", VA = "0x111F0D50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000771")]
    [IgnoreMember]
    public bool IsMatch
    {
      [Token(Token = "0x60047D5"), Address(RVA = "0x11F1100", Offset = "0x11EFF00", VA = "0x111F1100")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000772")]
    [IgnoreMember]
    public bool IsDisassemble
    {
      [Token(Token = "0x60047D6"), Address(RVA = "0x288080", Offset = "0x286E80", VA = "0x10288080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60047D7")]
    [Address(RVA = "0x11EF980", Offset = "0x11EE780", VA = "0x111EF980")]
    public UnitData GetOwner(bool is_include_over_write = false) => (UnitData) null;

    [Token(Token = "0x60047D8")]
    [Address(RVA = "0x11EE920", Offset = "0x11ED720", VA = "0x111EE920")]
    public void CreateBaseStatusFromBaseParam(
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x60047D9")]
    [Address(RVA = "0x11EEAF0", Offset = "0x11ED8F0", VA = "0x111EEAF0")]
    public void CreateBaseStatusFromOnlyBaseParam(
      ref BaseStatus addOnlyBaseStatus,
      ref BaseStatus scaleOnlyBaseStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x60047DA")]
    [Address(RVA = "0x11EE960", Offset = "0x11ED760", VA = "0x111EE960")]
    public void CreateBaseStatusFromDedicated(
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x60047DB")]
    [Address(RVA = "0x11F0A20", Offset = "0x11EF820", VA = "0x111F0A20")]
    public float PowerPercentageFromBaseParam() => new float();

    [Token(Token = "0x60047DC")]
    [Address(RVA = "0x11EF940", Offset = "0x11EE740", VA = "0x111EF940")]
    public int GetLengthFromEvoParam() => new int();

    [Token(Token = "0x60047DD")]
    [Address(RVA = "0x11F0AC0", Offset = "0x11EF8C0", VA = "0x111F0AC0")]
    public float PowerPercentageFromEvoParam(int index) => new float();

    [Token(Token = "0x60047DE")]
    [Address(RVA = "0x11EEA60", Offset = "0x11ED860", VA = "0x111EEA60")]
    public void CreateBaseStatusFromEvoParam(
      int index,
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x60047DF")]
    [Address(RVA = "0x11EF8C0", Offset = "0x11EE6C0", VA = "0x111EF8C0")]
    public int GetEvoSlot(int index) => new int();

    [Token(Token = "0x60047E0")]
    [Address(RVA = "0x11EF800", Offset = "0x11EE600", VA = "0x111EF800")]
    public int GetEvoIndex(int evo_slot_id) => new int();

    [Token(Token = "0x60047E1")]
    [Address(RVA = "0x11EFD70", Offset = "0x11EEB70", VA = "0x111EFD70")]
    public long GetSortData(
      eRuneSortType type,
      bool isBaseParamSort,
      bool isEvoParamSort,
      bool isSetParamSort)
    {
      return new long();
    }

    [Token(Token = "0x60047E2")]
    [Address(RVA = "0x11EEC90", Offset = "0x11EDA90", VA = "0x111EEC90")]
    public string DisplayRuneBaseParam() => (string) null;

    [Token(Token = "0x60047E3")]
    [Address(RVA = "0x11F03C0", Offset = "0x11EF1C0", VA = "0x111F03C0")]
    public List<long> GetSortData(eRuneSortType type, bool _is_ascending) => (List<long>) null;

    [Token(Token = "0x60047E4")]
    [Address(RVA = "0x11EE7E0", Offset = "0x11ED5E0", VA = "0x111EE7E0")]
    private long CheckHasStatus(int _status, bool _is_ascending) => new long();

    [Token(Token = "0x60047E5")]
    [Address(RVA = "0x11EE800", Offset = "0x11ED600", VA = "0x111EE800")]
    private long CheckStatusParamCoefficient(StatusParam _param, bool _is_ascending) => new long();

    [Token(Token = "0x60047E6")]
    [Address(RVA = "0x11F07A0", Offset = "0x11EF5A0", VA = "0x111F07A0")]
    private long GetStatusParamNum(StatusParam _param) => new long();

    [Token(Token = "0x60047E7")]
    [Address(RVA = "0x11EF520", Offset = "0x11EE320", VA = "0x111EF520")]
    public bool Filter(FilterRunePrefs filter) => new bool();

    [Token(Token = "0x60047E8")]
    [Address(RVA = "0x11F09E0", Offset = "0x11EF7E0", VA = "0x111F09E0")]
    public bool IsMatchDedicated(long unit_id) => new bool();

    [Token(Token = "0x60047E9")]
    [Address(RVA = "0x11EFB10", Offset = "0x11EE910", VA = "0x111EFB10")]
    public string GetRuneName() => (string) null;

    [Token(Token = "0x60047EA")]
    [Address(RVA = "0x11EE5D0", Offset = "0x11ED3D0", VA = "0x111EE5D0")]
    public void AddRuneBaseStatus(
      EElement buffTargetElement,
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      long unitId = 0)
    {
    }

    [Token(Token = "0x60047EB")]
    [Address(RVA = "0x11F08C0", Offset = "0x11EF6C0", VA = "0x111F08C0")]
    public bool IsCanEnhanceEvoParam(int evo_index) => new bool();

    [Token(Token = "0x60047EC")]
    [Address(RVA = "0x11F0CA0", Offset = "0x11EFAA0", VA = "0x111F0CA0")]
    public void SetOverWriteSlotIndex(int index)
    {
    }

    [Token(Token = "0x60047ED")]
    [Address(RVA = "0x11F0CC0", Offset = "0x11EFAC0", VA = "0x111F0CC0")]
    public RuneData()
    {
    }
  }
}
