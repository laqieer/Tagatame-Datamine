// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMailRead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200308B")]
  public class ReqMailRead : WebAPI
  {
    [Token(Token = "0x600DD09")]
    [Address(RVA = "0xA87D30", Offset = "0xA86B30", VA = "0x10A87D30")]
    public ReqMailRead(long[] mailids, bool period, int page, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DD0A")]
    [Address(RVA = "0xA87B00", Offset = "0xA86900", VA = "0x10A87B00")]
    public ReqMailRead(long[] mailids, int[] periods, int page, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DD0B")]
    [Address(RVA = "0xA87F70", Offset = "0xA86D70", VA = "0x10A87F70")]
    public ReqMailRead(
      long mailid,
      bool period,
      int page,
      string iname,
      Network.ResponseCallback response)
    {
    }
  }
}
