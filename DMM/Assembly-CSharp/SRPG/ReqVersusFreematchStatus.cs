// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusFreematchStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003152")]
  public class ReqVersusFreematchStatus : WebAPI
  {
    [Token(Token = "0x600DDE8")]
    [Address(RVA = "0xA8EAE0", Offset = "0xA8D8E0", VA = "0x10A8EAE0")]
    public ReqVersusFreematchStatus(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003153")]
    public class EnableTimeSchedule
    {
      [Token(Token = "0x400ED0D")]
      [FieldOffset(Offset = "0x8")]
      public long expired;
      [Token(Token = "0x400ED0E")]
      [FieldOffset(Offset = "0x10")]
      public long next;

      [Token(Token = "0x600DDE9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public EnableTimeSchedule()
      {
      }
    }

    [Token(Token = "0x2003154")]
    public class Response
    {
      [Token(Token = "0x400ED0F")]
      [FieldOffset(Offset = "0x8")]
      public ReqVersusFreematchStatus.EnableTimeSchedule enabletime;

      [Token(Token = "0x600DDEA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
