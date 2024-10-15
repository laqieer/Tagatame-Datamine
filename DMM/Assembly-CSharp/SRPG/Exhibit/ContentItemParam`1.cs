// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ContentItemParam`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003433")]
  public class ContentItemParam<T> : ContentSource.Param where T : class
  {
    [Token(Token = "0x400F79C")]
    [FieldOffset(Offset = "0x0")]
    private T model;
    [Token(Token = "0x400F79D")]
    [FieldOffset(Offset = "0x0")]
    private Action<ContentNode, T> onAttach;

    [Token(Token = "0x600E93B")]
    public void Initialize(T _model, Action<ContentNode, T> _onAttach)
    {
    }

    [Token(Token = "0x600E93C")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600E93D")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600E93E")]
    public ContentItemParam()
    {
    }
  }
}
