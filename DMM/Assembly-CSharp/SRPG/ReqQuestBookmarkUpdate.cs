// Decompiled with JetBrains decompiler
// Type: SRPG.ReqQuestBookmarkUpdate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031CF")]
  public class ReqQuestBookmarkUpdate : WebAPI
  {
    [Token(Token = "0x600DE68")]
    [Address(RVA = "0xA9B6D0", Offset = "0xA9A4D0", VA = "0x10A9B6D0")]
    public ReqQuestBookmarkUpdate(
      IEnumerable<string> add,
      IEnumerable<string> delete,
      Network.ResponseCallback response)
    {
    }
  }
}
