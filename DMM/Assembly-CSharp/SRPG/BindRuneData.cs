// Decompiled with JetBrains decompiler
// Type: SRPG.BindRuneData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010F5")]
  public class BindRuneData
  {
    [Token(Token = "0x4003D3E")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x4003D3F")]
    [FieldOffset(Offset = "0x10")]
    public bool is_selected;
    [Token(Token = "0x4003D40")]
    [FieldOffset(Offset = "0x11")]
    public bool is_disable;
    [Token(Token = "0x4003D41")]
    [FieldOffset(Offset = "0x12")]
    public bool is_check;
    [Token(Token = "0x4003D42")]
    [FieldOffset(Offset = "0x13")]
    public bool is_owner_disable;
    [Token(Token = "0x4003D43")]
    [FieldOffset(Offset = "0x14")]
    public bool is_use_copy;
    [Token(Token = "0x4003D44")]
    [FieldOffset(Offset = "0x18")]
    private RuneData CopyRune;

    [Token(Token = "0x60047A2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BindRuneData()
    {
    }

    [Token(Token = "0x60047A3")]
    [Address(RVA = "0xA7DDA0", Offset = "0xA7CBA0", VA = "0x10A7DDA0")]
    public BindRuneData(long _iid)
    {
    }

    [Token(Token = "0x17000746")]
    public RuneData Rune
    {
      [Token(Token = "0x60047A4"), Address(RVA = "0x11EDBC0", Offset = "0x11EC9C0", VA = "0x111EDBC0")] get
      {
        return (RuneData) null;
      }
    }

    [Token(Token = "0x17000747")]
    public RuneParam RuneParam
    {
      [Token(Token = "0x60047A5"), Address(RVA = "0x11EDB90", Offset = "0x11EC990", VA = "0x111EDB90")] get
      {
        return (RuneParam) null;
      }
    }

    [Token(Token = "0x17000748")]
    public RuneMaterial RuneMaterialList
    {
      [Token(Token = "0x60047A6"), Address(RVA = "0x11EDAD0", Offset = "0x11EC8D0", VA = "0x111EDAD0")] get
      {
        return (RuneMaterial) null;
      }
    }

    [Token(Token = "0x17000749")]
    public RuneCost EnhanceCost
    {
      [Token(Token = "0x60047A7"), Address(RVA = "0x11ED6C0", Offset = "0x11EC4C0", VA = "0x111ED6C0")] get
      {
        return (RuneCost) null;
      }
    }

    [Token(Token = "0x1700074A")]
    public int DisassemblyZeny
    {
      [Token(Token = "0x60047A8"), Address(RVA = "0x11ED690", Offset = "0x11EC490", VA = "0x111ED690")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700074B")]
    public RuneCost EvoCost
    {
      [Token(Token = "0x60047A9"), Address(RVA = "0x11ED750", Offset = "0x11EC550", VA = "0x111ED750")] get
      {
        return (RuneCost) null;
      }
    }

    [Token(Token = "0x1700074C")]
    public RuneCost[] ResetParamBaseCost
    {
      [Token(Token = "0x60047AA"), Address(RVA = "0x11EDA50", Offset = "0x11EC850", VA = "0x111EDA50")] get
      {
        return (RuneCost[]) null;
      }
    }

    [Token(Token = "0x1700074D")]
    public RuneCost[] ResetStatusEvoCost
    {
      [Token(Token = "0x60047AB"), Address(RVA = "0x11EDA90", Offset = "0x11EC890", VA = "0x111EDA90")] get
      {
        return (RuneCost[]) null;
      }
    }

    [Token(Token = "0x1700074E")]
    public RuneCost[] ParamEnhEvoCost
    {
      [Token(Token = "0x60047AC"), Address(RVA = "0x11ED9C0", Offset = "0x11EC7C0", VA = "0x111ED9C0")] get
      {
        return (RuneCost[]) null;
      }
    }

    [Token(Token = "0x60047AD")]
    [Address(RVA = "0x11ED4F0", Offset = "0x11EC2F0", VA = "0x111ED4F0")]
    public UnitData GetOwner() => (UnitData) null;

    [Token(Token = "0x1700074F")]
    public RuneMaterial RuneMaterial
    {
      [Token(Token = "0x60047AE"), Address(RVA = "0x11EDB00", Offset = "0x11EC900", VA = "0x111EDB00")] get
      {
        return (RuneMaterial) null;
      }
    }

    [Token(Token = "0x17000750")]
    public UnitData UnitData
    {
      [Token(Token = "0x60047AF"), Address(RVA = "0x11EDC30", Offset = "0x11ECA30", VA = "0x111EDC30")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17000751")]
    public int EnhanceNum
    {
      [Token(Token = "0x60047B0"), Address(RVA = "0x11ED720", Offset = "0x11EC520", VA = "0x111ED720")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000752")]
    public bool IsEvoNext
    {
      [Token(Token = "0x60047B1"), Address(RVA = "0x11ED890", Offset = "0x11EC690", VA = "0x111ED890")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000753")]
    public bool IsCanEvo
    {
      [Token(Token = "0x60047B2"), Address(RVA = "0x11ED7D0", Offset = "0x11EC5D0", VA = "0x111ED7D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000754")]
    public int EvoNum
    {
      [Token(Token = "0x60047B3"), Address(RVA = "0x11ED7B0", Offset = "0x11EC5B0", VA = "0x111ED7B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000755")]
    public ItemParam Item
    {
      [Token(Token = "0x60047B4"), Address(RVA = "0x11ED990", Offset = "0x11EC790", VA = "0x111ED990")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17000756")]
    public int Rarity
    {
      [Token(Token = "0x60047B5"), Address(RVA = "0x11EDA00", Offset = "0x11EC800", VA = "0x111EDA00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000757")]
    public bool IsFavorite
    {
      [Token(Token = "0x60047B6"), Address(RVA = "0x11ED910", Offset = "0x11EC710", VA = "0x111ED910")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000758")]
    public bool IsDedicated
    {
      [Token(Token = "0x60047B7"), Address(RVA = "0x11ED850", Offset = "0x11EC650", VA = "0x111ED850")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000759")]
    public bool CanDedicated
    {
      [Token(Token = "0x60047B8"), Address(RVA = "0x11ED540", Offset = "0x11EC340", VA = "0x111ED540")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700075A")]
    public bool IsMatchDedicated
    {
      [Token(Token = "0x60047B9"), Address(RVA = "0x11ED930", Offset = "0x11EC730", VA = "0x111ED930")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60047BA")]
    [Address(RVA = "0x11ED220", Offset = "0x11EC020", VA = "0x111ED220")]
    public BindRuneData CreateCopyRune() => (BindRuneData) null;

    [Token(Token = "0x60047BB")]
    [Address(RVA = "0x11ED520", Offset = "0x11EC320", VA = "0x111ED520")]
    public void ResetOptionParam()
    {
    }
  }
}
