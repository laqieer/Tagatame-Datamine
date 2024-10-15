// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ContentItemSource`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003432")]
  public class ContentItemSource<T> : ContentSource where T : class
  {
    [Token(Token = "0x600E939")]
    public void Setup(List<T> models, Action<ContentNode, T> onAttach)
    {
    }

    [Token(Token = "0x600E93A")]
    public ContentItemSource()
    {
    }
  }
}
