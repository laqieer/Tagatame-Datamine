// Decompiled with JetBrains decompiler
// Type: CanvasStack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200002C")]
[AddComponentMenu("Layout/Canvas Stack")]
[RequireComponent(typeof (Canvas))]
[DisallowMultipleComponent]
public class CanvasStack : MonoBehaviour
{
  [Token(Token = "0x40000CA")]
  [FieldOffset(Offset = "0x0")]
  private static List<CanvasStack> mStack;
  [Token(Token = "0x40000CB")]
  [FieldOffset(Offset = "0xC")]
  private Canvas mCanvas;
  [Token(Token = "0x40000CC")]
  [FieldOffset(Offset = "0x10")]
  private GraphicRaycaster mRaycaster;
  [Token(Token = "0x40000CD")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private int mPriority;
  [Token(Token = "0x40000CE")]
  [FieldOffset(Offset = "0x18")]
  public bool Modal;
  [Token(Token = "0x40000CF")]
  [FieldOffset(Offset = "0x19")]
  public bool SystemModal;
  [Token(Token = "0x40000D0")]
  [FieldOffset(Offset = "0x4")]
  private static bool mBlockRaycasts;

  [Token(Token = "0x17000014")]
  public int Priority
  {
    [Token(Token = "0x6000105"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
    {
      return new int();
    }
    [Token(Token = "0x6000106"), Address(RVA = "0x2C2EF0", Offset = "0x2C1CF0", VA = "0x102C2EF0")] set
    {
    }
  }

  [Token(Token = "0x6000107")]
  [Address(RVA = "0x2C1FE0", Offset = "0x2C0DE0", VA = "0x102C1FE0")]
  public static void HideCanvases(int maxPriority)
  {
  }

  [Token(Token = "0x6000108")]
  [Address(RVA = "0x2C21C0", Offset = "0x2C0FC0", VA = "0x102C21C0")]
  public static void ShowAllCanvases()
  {
  }

  [Token(Token = "0x6000109")]
  [Address(RVA = "0x2C1EB0", Offset = "0x2C0CB0", VA = "0x102C1EB0")]
  public static void BlockRaycasts(bool block)
  {
  }

  [Token(Token = "0x600010A")]
  [Address(RVA = "0x2C1E10", Offset = "0x2C0C10", VA = "0x102C1E10")]
  private void Awake()
  {
  }

  [Token(Token = "0x600010B")]
  [Address(RVA = "0x2C2290", Offset = "0x2C1090", VA = "0x102C2290")]
  public static void SortCanvases()
  {
  }

  [Token(Token = "0x600010C")]
  [Address(RVA = "0x2C2A60", Offset = "0x2C1860", VA = "0x102C2A60")]
  private static void UpdateGraphicRaycasters()
  {
  }

  [Token(Token = "0x600010D")]
  [Address(RVA = "0x2C2150", Offset = "0x2C0F50", VA = "0x102C2150")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x17000015")]
  public static Canvas Base
  {
    [Token(Token = "0x600010E"), Address(RVA = "0x2C2DB0", Offset = "0x2C1BB0", VA = "0x102C2DB0")] get
    {
      return (Canvas) null;
    }
  }

  [Token(Token = "0x17000016")]
  public static Canvas Top
  {
    [Token(Token = "0x600010F"), Address(RVA = "0x2C2E50", Offset = "0x2C1C50", VA = "0x102C2E50")] get
    {
      return (Canvas) null;
    }
  }

  [Token(Token = "0x6000110")]
  [Address(RVA = "0x2C2D80", Offset = "0x2C1B80", VA = "0x102C2D80")]
  public CanvasStack()
  {
  }

  [Token(Token = "0x6000111")]
  [Address(RVA = "0x2C2CF0", Offset = "0x2C1AF0", VA = "0x102C2CF0")]
  static CanvasStack()
  {
  }
}
