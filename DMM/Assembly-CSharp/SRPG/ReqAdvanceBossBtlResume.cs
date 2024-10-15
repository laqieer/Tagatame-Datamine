// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdvanceBossBtlResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200321A")]
  public class ReqAdvanceBossBtlResume : WebAPI
  {
    [Token(Token = "0x600DEB6")]
    [Address(RVA = "0xA92F00", Offset = "0xA91D00", VA = "0x10A92F00")]
    public ReqAdvanceBossBtlResume(long btlid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200321B")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE0A")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;

      [Token(Token = "0x600DEB7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
