// Decompiled with JetBrains decompiler
// Type: SRPG.RarityEquipEnhanceParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E18")]
  [MessagePackObject(true)]
  public class RarityEquipEnhanceParam
  {
    [Token(Token = "0x4007A76")]
    [FieldOffset(Offset = "0x8")]
    public OInt rankcap;
    [Token(Token = "0x4007A77")]
    [FieldOffset(Offset = "0x1C")]
    public OInt cost_scale;
    [Token(Token = "0x4007A78")]
    [FieldOffset(Offset = "0x30")]
    public RarityEquipEnhanceParam.RankParam[] ranks;

    [Token(Token = "0x6007B88")]
    [Address(RVA = "0x3E2470", Offset = "0x3E1270", VA = "0x103E2470")]
    public RarityEquipEnhanceParam.RankParam GetRankParam(int rank)
    {
      return (RarityEquipEnhanceParam.RankParam) null;
    }

    [Token(Token = "0x6007B89")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RarityEquipEnhanceParam()
    {
    }

    [Token(Token = "0x2001E19")]
    [MessagePackObject(true)]
    public class RankParam
    {
      [Token(Token = "0x4007A79")]
      [FieldOffset(Offset = "0x8")]
      public OInt need_point;
      [Token(Token = "0x4007A7A")]
      [FieldOffset(Offset = "0x1C")]
      public ReturnItem[] return_item;

      [Token(Token = "0x6007B8A")]
      [Address(RVA = "0x3E2420", Offset = "0x3E1220", VA = "0x103E2420")]
      public RankParam()
      {
      }
    }
  }
}
