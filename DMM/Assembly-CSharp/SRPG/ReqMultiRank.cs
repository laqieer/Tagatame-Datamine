// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiRank
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200310B")]
  public class ReqMultiRank : WebAPI
  {
    [Token(Token = "0x600DD9E")]
    [Address(RVA = "0xA88980", Offset = "0xA87780", VA = "0x10A88980")]
    public ReqMultiRank(string iname, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200310C")]
    public class Json_MultiRankParam
    {
      [Token(Token = "0x400EC78")]
      [FieldOffset(Offset = "0x8")]
      public string unit_iname;
      [Token(Token = "0x400EC79")]
      [FieldOffset(Offset = "0xC")]
      public string job_iname;

      [Token(Token = "0x600DD9F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_MultiRankParam()
      {
      }
    }

    [Token(Token = "0x200310D")]
    public class Json_MultiRank
    {
      [Token(Token = "0x400EC7A")]
      [FieldOffset(Offset = "0x8")]
      public ReqMultiRank.Json_MultiRankParam[] ranking;
      [Token(Token = "0x400EC7B")]
      [FieldOffset(Offset = "0xC")]
      public int isReady;

      [Token(Token = "0x600DDA0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_MultiRank()
      {
      }
    }
  }
}
