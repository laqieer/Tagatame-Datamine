// Decompiled with JetBrains decompiler
// Type: SRPG.ReqEquipExpAdd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030CB")]
  public class ReqEquipExpAdd : WebAPI
  {
    [Token(Token = "0x600DD50")]
    [Address(RVA = "0xA84450", Offset = "0xA83250", VA = "0x10A84450")]
    public ReqEquipExpAdd(
      long iid,
      int slot,
      Dictionary<string, int> usedItems,
      Network.ResponseCallback response)
    {
    }
  }
}
