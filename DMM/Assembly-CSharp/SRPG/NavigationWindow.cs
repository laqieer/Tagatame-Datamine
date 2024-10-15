// Decompiled with JetBrains decompiler
// Type: SRPG.NavigationWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027B4")]
  [AddComponentMenu("UI/NavigationWindow")]
  public class NavigationWindow : MonoBehaviour
  {
    [Token(Token = "0x400BBF9")]
    [FieldOffset(Offset = "0x0")]
    private static NavigationWindow mCurrent;
    [Token(Token = "0x400BBFA")]
    [FieldOffset(Offset = "0x4")]
    private static int mNumNavigations;
    [Token(Token = "0x400BBFB")]
    [FieldOffset(Offset = "0x8")]
    private static GameObject mNavigationCanvas;
    [Token(Token = "0x400BBFC")]
    private const int CanvasPriority = 5000;
    [Token(Token = "0x400BBFD")]
    [FieldOffset(Offset = "0xC")]
    public Text Text;
    [Token(Token = "0x400BBFE")]
    [FieldOffset(Offset = "0x10")]
    public float DestroyDelay;
    [Token(Token = "0x400BBFF")]
    [FieldOffset(Offset = "0x14")]
    public string HideTrigger;
    [Token(Token = "0x400BC00")]
    [FieldOffset(Offset = "0x18")]
    public Vector2 Margin;
    [Token(Token = "0x400BC01")]
    [FieldOffset(Offset = "0x20")]
    private Animator mAnimator;
    [Token(Token = "0x400BC02")]
    [FieldOffset(Offset = "0x24")]
    private RectTransform mRect;

    [Token(Token = "0x600B253")]
    [Address(RVA = "0x7A6990", Offset = "0x7A5790", VA = "0x107A6990")]
    public static void DiscardCurrent()
    {
    }

    [Token(Token = "0x600B254")]
    [Address(RVA = "0x7A6D80", Offset = "0x7A5B80", VA = "0x107A6D80")]
    public static void Show(
      NavigationWindow template,
      string text,
      NavigationWindow.Alignment align)
    {
    }

    [Token(Token = "0x600B255")]
    [Address(RVA = "0x7A6920", Offset = "0x7A5720", VA = "0x107A6920")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B256")]
    [Address(RVA = "0x7A7220", Offset = "0x7A6020", VA = "0x107A7220")]
    private void Start()
    {
    }

    [Token(Token = "0x600B257")]
    [Address(RVA = "0x7A6AF0", Offset = "0x7A58F0", VA = "0x107A6AF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B258")]
    [Address(RVA = "0x5A9D10", Offset = "0x5A8B10", VA = "0x105A9D10")]
    private void SetText(string text)
    {
    }

    [Token(Token = "0x600B259")]
    [Address(RVA = "0x7A6B90", Offset = "0x7A5990", VA = "0x107A6B90")]
    private void SetAlignment(NavigationWindow.Alignment alignment)
    {
    }

    [Token(Token = "0x600B25A")]
    [Address(RVA = "0x7A73C0", Offset = "0x7A61C0", VA = "0x107A73C0")]
    public NavigationWindow()
    {
    }

    [Token(Token = "0x20027B5")]
    public enum Alignment
    {
      [Token(Token = "0x400BC0B")] BottomLeft = 0,
      [Token(Token = "0x400BC0A")] Bottom = 1,
      [Token(Token = "0x400BC0C")] BottomRight = 2,
      [Token(Token = "0x400BC08")] MiddleLeft = 4,
      [Token(Token = "0x400BC07")] Middle = 5,
      [Token(Token = "0x400BC09")] MiddleRight = 6,
      [Token(Token = "0x400BC05")] TopLeft = 8,
      [Token(Token = "0x400BC04")] Top = 9,
      [Token(Token = "0x400BC06")] TopRight = 10, // 0x0000000A
    }
  }
}
