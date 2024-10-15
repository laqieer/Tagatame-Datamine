// Decompiled with JetBrains decompiler
// Type: UIWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002FF")]
[RequireComponent(typeof (CanvasGroup))]
[AddComponentMenu("UI/Window")]
[RequireComponent(typeof (Animator))]
public class UIWindow : MonoBehaviour
{
  [Token(Token = "0x4000C50")]
  [FieldOffset(Offset = "0xC")]
  public string OpenState;
  [Token(Token = "0x4000C51")]
  [FieldOffset(Offset = "0x10")]
  public string WaitState;
  [Token(Token = "0x4000C52")]
  [FieldOffset(Offset = "0x14")]
  public string CloseState;
  [Token(Token = "0x4000C53")]
  [FieldOffset(Offset = "0x18")]
  private bool mClose;
  [Token(Token = "0x4000C54")]
  [FieldOffset(Offset = "0x19")]
  private bool mUpdateAnimatorState;
  [Token(Token = "0x4000C55")]
  [FieldOffset(Offset = "0x1A")]
  private bool mWaitForAnimatorStateChange;
  [Token(Token = "0x4000C56")]
  [FieldOffset(Offset = "0x1C")]
  public UIWindow.WindowEvent OnWindowClose;
  [Token(Token = "0x4000C57")]
  [FieldOffset(Offset = "0x20")]
  public UIWindow.WindowEvent OnWindowOpen;

  [Token(Token = "0x170001D4")]
  public bool IsClosed
  {
    [Token(Token = "0x6000F8E"), Address(RVA = "0x12AA980", Offset = "0x12A9780", VA = "0x112AA980")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001D5")]
  public bool IsOpened
  {
    [Token(Token = "0x6000F8F"), Address(RVA = "0x12AAA50", Offset = "0x12A9850", VA = "0x112AAA50")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000F90")]
  [Address(RVA = "0x12AA570", Offset = "0x12A9370", VA = "0x112AA570")]
  public static bool CheckOpened(GameObject obj) => new bool();

  [Token(Token = "0x6000F91")]
  [Address(RVA = "0x12AA480", Offset = "0x12A9280", VA = "0x112AA480")]
  public static bool CheckClosed(GameObject obj) => new bool();

  [Token(Token = "0x6000F92")]
  [Address(RVA = "0x12AA6E0", Offset = "0x12A94E0", VA = "0x112AA6E0")]
  public void Open()
  {
  }

  [Token(Token = "0x6000F93")]
  [Address(RVA = "0x12AA660", Offset = "0x12A9460", VA = "0x112AA660")]
  public void Close()
  {
  }

  [Token(Token = "0x6000F94")]
  [Address(RVA = "0x12AA790", Offset = "0x12A9590", VA = "0x112AA790")]
  private void UpdateAnimatorState()
  {
  }

  [Token(Token = "0x6000F95")]
  [Address(RVA = "0x12AA400", Offset = "0x12A9200", VA = "0x112AA400")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000F96")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000F97")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000F98")]
  [Address(RVA = "0x12AA800", Offset = "0x12A9600", VA = "0x112AA800")]
  private void Update()
  {
  }

  [Token(Token = "0x6000F99")]
  [Address(RVA = "0x12AA8F0", Offset = "0x12A96F0", VA = "0x112AA8F0")]
  public UIWindow()
  {
  }

  [Token(Token = "0x2000300")]
  public delegate void WindowEvent(UIWindow window);
}
