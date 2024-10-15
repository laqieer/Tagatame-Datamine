// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollListSetUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A7D")]
  public interface ScrollListSetUp
  {
    [Token(Token = "0x600C203")]
    void OnSetUpItems();

    [Token(Token = "0x600C204")]
    void OnUpdateItems(int idx, GameObject obj);
  }
}
