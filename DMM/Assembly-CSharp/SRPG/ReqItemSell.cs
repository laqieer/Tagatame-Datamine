// Decompiled with JetBrains decompiler
// Type: SRPG.ReqItemSell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030D2")]
  public class ReqItemSell : WebAPI
  {
    [Token(Token = "0x600DD57")]
    [Address(RVA = "0xA861A0", Offset = "0xA84FA0", VA = "0x10A861A0")]
    public ReqItemSell(
      Dictionary<long, int> sells,
      bool is_item_convert,
      Network.ResponseCallback response)
    {
    }
  }
}
