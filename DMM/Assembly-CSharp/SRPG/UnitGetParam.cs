// Decompiled with JetBrains decompiler
// Type: SRPG.UnitGetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C32")]
  public class UnitGetParam
  {
    [Token(Token = "0x400DAD8")]
    [FieldOffset(Offset = "0x8")]
    public List<UnitGetParam.Set> Params;

    [Token(Token = "0x600CCB5")]
    [Address(RVA = "0x976E20", Offset = "0x975C20", VA = "0x10976E20")]
    public UnitGetParam(ItemParam param)
    {
    }

    [Token(Token = "0x600CCB6")]
    [Address(RVA = "0x976EA0", Offset = "0x975CA0", VA = "0x10976EA0")]
    public UnitGetParam(ItemParam[] paramLsit)
    {
    }

    [Token(Token = "0x600CCB7")]
    [Address(RVA = "0x976C70", Offset = "0x975A70", VA = "0x10976C70")]
    public UnitGetParam(ItemData data)
    {
    }

    [Token(Token = "0x600CCB8")]
    [Address(RVA = "0x976D00", Offset = "0x975B00", VA = "0x10976D00")]
    public UnitGetParam(ItemData[] paramLsit)
    {
    }

    [Token(Token = "0x600CCB9")]
    [Address(RVA = "0x976B50", Offset = "0x975950", VA = "0x10976B50")]
    public UnitGetParam(GiftData[] paramList)
    {
    }

    [Token(Token = "0x600CCBA")]
    [Address(RVA = "0x976B30", Offset = "0x975930", VA = "0x10976B30")]
    public void Add(ItemParam param)
    {
    }

    [Token(Token = "0x600CCBB")]
    [Address(RVA = "0x9768C0", Offset = "0x9756C0", VA = "0x109768C0")]
    private void AddInternal(ItemParam param, List<UnitData> units = null)
    {
    }

    [Token(Token = "0x600CCBC")]
    [Address(RVA = "0x976740", Offset = "0x975540", VA = "0x10976740")]
    public void AddArary(ItemParam[] list)
    {
    }

    [Token(Token = "0x600CCBD")]
    [Address(RVA = "0x976800", Offset = "0x975600", VA = "0x10976800")]
    public void AddArary(ItemData[] list)
    {
    }

    [Token(Token = "0x2002C33")]
    public class Set
    {
      [Token(Token = "0x400DAD9")]
      [FieldOffset(Offset = "0x8")]
      public string ItemId;
      [Token(Token = "0x400DADA")]
      [FieldOffset(Offset = "0xC")]
      public EItemType ItemType;
      [Token(Token = "0x400DADB")]
      [FieldOffset(Offset = "0x10")]
      public bool IsConvert;
      [Token(Token = "0x400DADC")]
      [FieldOffset(Offset = "0x14")]
      public int ConvertPieceNum;
      [Token(Token = "0x400DADD")]
      [FieldOffset(Offset = "0x18")]
      public UnitParam UnitParam;

      [Token(Token = "0x600CCBE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Set()
      {
      }
    }
  }
}
