// Decompiled with JetBrains decompiler
// Type: Hypertext.HypertextBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace Hypertext
{
  [Token(Token = "0x2000B43")]
  public abstract class HypertextBase : Text, IPointerClickHandler, IEventSystemHandler
  {
    [Token(Token = "0x4001B16")]
    [FieldOffset(Offset = "0x98")]
    private readonly List<HypertextBase.Span> spans;
    [Token(Token = "0x4001B17")]
    [FieldOffset(Offset = "0x9C")]
    private readonly char[] invisibleChars;
    [Token(Token = "0x4001B18")]
    [FieldOffset(Offset = "0x0")]
    private static readonly ObjectPool<List<UIVertex>> verticesPool;
    [Token(Token = "0x4001B19")]
    private const int CharVerts = 6;
    [Token(Token = "0x4001B1A")]
    private const char Tab = '\t';
    [Token(Token = "0x4001B1B")]
    private const char LineFeed = '\n';
    [Token(Token = "0x4001B1C")]
    private const char Space = ' ';
    [Token(Token = "0x4001B1D")]
    private const char LesserThan = '<';
    [Token(Token = "0x4001B1E")]
    private const char GreaterThan = '>';
    [Token(Token = "0x4001B1F")]
    [FieldOffset(Offset = "0xA0")]
    private int[] visibleCharIndexMap;
    [Token(Token = "0x4001B20")]
    [FieldOffset(Offset = "0xA4")]
    private Canvas rootCanvas;
    [Token(Token = "0x4001B21")]
    [FieldOffset(Offset = "0xA8")]
    private readonly UIVertex[] tempVerts;

    [Token(Token = "0x17000213")]
    private Canvas RootCanvas
    {
      [Token(Token = "0x6002B17"), Address(RVA = "0xF65510", Offset = "0xF64310", VA = "0x10F65510")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x6002B18")]
    [Address(RVA = "0xF64580", Offset = "0xF63380", VA = "0x10F64580")]
    protected void OnClick(int startIndex, int length, Color color, Action<string> onClick)
    {
    }

    [Token(Token = "0x6002B19")]
    [Address(RVA = "0xF64EE0", Offset = "0xF63CE0", VA = "0x10F64EE0", Slot = "86")]
    public virtual void RemoveListeners()
    {
    }

    [Token(Token = "0x6002B1A")]
    protected abstract void AddListeners();

    [Token(Token = "0x6002B1B")]
    [Address(RVA = "0xF647A0", Offset = "0xF635A0", VA = "0x10F647A0", Slot = "44")]
    protected override void OnPopulateMesh(VertexHelper toFill)
    {
    }

    [Token(Token = "0x6002B1C")]
    [Address(RVA = "0xF63FF0", Offset = "0xF62DF0", VA = "0x10F63FF0")]
    private void GenerateHrefBoundingBoxes(ref List<UIVertex> vertices)
    {
    }

    [Token(Token = "0x6002B1D")]
    [Address(RVA = "0xF63C40", Offset = "0xF62A40", VA = "0x10F63C40")]
    private static List<Rect> CalculateLineBoundingBoxes(List<Rect> charBoundingBoxes)
    {
      return (List<Rect>) null;
    }

    [Token(Token = "0x6002B1E")]
    [Address(RVA = "0xF63880", Offset = "0xF62680", VA = "0x10F63880")]
    private static Rect CalculateAABB(IReadOnlyList<Rect> rects) => new Rect();

    [Token(Token = "0x6002B1F")]
    [Address(RVA = "0xF64390", Offset = "0xF63190", VA = "0x10F64390")]
    private void GenerateVisibleCharIndexMap(bool verticesReduced)
    {
    }

    [Token(Token = "0x6002B20")]
    [Address(RVA = "0xF63E20", Offset = "0xF62C20", VA = "0x10F63E20")]
    private Vector3 CalculateLocalPosition(Vector3 position, Camera pressEventCamera)
    {
      return new Vector3();
    }

    [Token(Token = "0x6002B21")]
    [Address(RVA = "0xF64F40", Offset = "0xF63D40", VA = "0x10F64F40", Slot = "85")]
    private void UnityEngine\u002EEventSystems\u002EIPointerClickHandler\u002EOnPointerClick(
      PointerEventData eventData)
    {
    }

    [Token(Token = "0x6002B22")]
    [Address(RVA = "0xF65430", Offset = "0xF64230", VA = "0x10F65430")]
    protected HypertextBase()
    {
    }

    [Token(Token = "0x6002B23")]
    [Address(RVA = "0xF65350", Offset = "0xF64150", VA = "0x10F65350")]
    static HypertextBase()
    {
    }

    [Token(Token = "0x2000B44")]
    private class Span
    {
      [Token(Token = "0x4001B22")]
      [FieldOffset(Offset = "0x8")]
      public readonly int StartIndex;
      [Token(Token = "0x4001B23")]
      [FieldOffset(Offset = "0xC")]
      public readonly int Length;
      [Token(Token = "0x4001B24")]
      [FieldOffset(Offset = "0x10")]
      public readonly Color Color;
      [Token(Token = "0x4001B25")]
      [FieldOffset(Offset = "0x20")]
      public readonly Action<string> Callback;
      [Token(Token = "0x4001B26")]
      [FieldOffset(Offset = "0x24")]
      public List<Rect> BoundingBoxes;

      [Token(Token = "0x6002B24")]
      [Address(RVA = "0xFD2AD0", Offset = "0xFD18D0", VA = "0x10FD2AD0")]
      public Span(int startIndex, int length, Color color, Action<string> callback)
      {
      }
    }
  }
}
