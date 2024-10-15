// Decompiled with JetBrains decompiler
// Type: SRPG.GvGMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B70")]
  public class GvGMaster
  {
    [Token(Token = "0x6007147")]
    public static void Deserialize<T, U>(ref List<T> obj, U[] json)
      where T : GvGMasterParam<U>, new()
      where U : JSON_GvGMasterParam
    {
    }

    [Token(Token = "0x6007148")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGMaster()
    {
    }
  }
}
