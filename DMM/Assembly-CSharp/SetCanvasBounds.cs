// Decompiled with JetBrains decompiler
// Type: SetCanvasBounds
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002D1")]
[AddComponentMenu("UI/SetCanvasBounds")]
public class SetCanvasBounds : MonoBehaviour
{
  [Token(Token = "0x4000BAF")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private bool IgnoreApplySafeAreaFlag;
  [Token(Token = "0x4000BB0")]
  [FieldOffset(Offset = "0x0")]
  private static Vector2 add2DFlamePos;
  [Token(Token = "0x4000BB1")]
  [FieldOffset(Offset = "0x8")]
  private static SetCanvasBounds.ScreenInfo m_CachedScreenInfo;
  [Token(Token = "0x4000BB2")]
  [FieldOffset(Offset = "0x10")]
  public RectTransform panel;
  [Token(Token = "0x4000BB3")]
  [FieldOffset(Offset = "0x14")]
  private Rect lastSafeArea;

  [Token(Token = "0x170001BF")]
  private static SetCanvasBounds.ScreenInfo CachedScreenInfo
  {
    [Token(Token = "0x6000EA7"), Address(RVA = "0x11D9190", Offset = "0x11D7F90", VA = "0x111D9190")] get
    {
      return (SetCanvasBounds.ScreenInfo) null;
    }
  }

  [Token(Token = "0x170001C0")]
  public static bool HasSafeArea
  {
    [Token(Token = "0x6000EA8"), Address(RVA = "0x11D9240", Offset = "0x11D8040", VA = "0x111D9240")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001C1")]
  public static bool IsWideScreen
  {
    [Token(Token = "0x6000EA9"), Address(RVA = "0x11D9260", Offset = "0x11D8060", VA = "0x111D9260")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000EAA")]
  [Address(RVA = "0x11D8C80", Offset = "0x11D7A80", VA = "0x111D8C80")]
  public static void ClearScreenInfo()
  {
  }

  [Token(Token = "0x6000EAB")]
  [Address(RVA = "0x11D8CD0", Offset = "0x11D7AD0", VA = "0x111D8CD0")]
  public static Vector2 GetAddFrame() => new Vector2();

  [Token(Token = "0x6000EAC")]
  [Address(RVA = "0x11D9090", Offset = "0x11D7E90", VA = "0x111D9090")]
  private static int PointToPixel(int pt, int retina) => new int();

  [Token(Token = "0x6000EAD")]
  [Address(RVA = "0x11D8B90", Offset = "0x11D7990", VA = "0x111D8B90")]
  private static Rect CalcSafeAreaPointToPixel(RectOffset edgeInsets, int retina) => new Rect();

  [Token(Token = "0x6000EAE")]
  [Address(RVA = "0x11D8E70", Offset = "0x11D7C70", VA = "0x111D8E70")]
  public static Rect GetSafeArea(bool bgScale = false) => new Rect();

  [Token(Token = "0x6000EAF")]
  [Address(RVA = "0x11D8AF0", Offset = "0x11D78F0", VA = "0x111D8AF0")]
  public static float CalcCanvasBoundsScale() => new float();

  [Token(Token = "0x6000EB0")]
  [Address(RVA = "0x11D90A0", Offset = "0x11D7EA0", VA = "0x111D90A0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000EB1")]
  [Address(RVA = "0x11D87A0", Offset = "0x11D75A0", VA = "0x111D87A0")]
  private void ApplySafeAreaScale(Rect area)
  {
  }

  [Token(Token = "0x6000EB2")]
  [Address(RVA = "0x11D9050", Offset = "0x11D7E50", VA = "0x111D9050")]
  public static Vector2 GetScreenSize() => new Vector2();

  [Token(Token = "0x6000EB3")]
  [Address(RVA = "0x11D8DF0", Offset = "0x11D7BF0", VA = "0x111D8DF0")]
  public static Rect GetCameraViewport() => new Rect();

  [Token(Token = "0x6000EB4")]
  [Address(RVA = "0x11D9130", Offset = "0x11D7F30", VA = "0x111D9130")]
  public SetCanvasBounds()
  {
  }

  [Token(Token = "0x20002D2")]
  private class ScreenInfo
  {
    [Token(Token = "0x4000BB4")]
    [FieldOffset(Offset = "0x8")]
    private Rect m_SafeArea;
    [Token(Token = "0x4000BB5")]
    [FieldOffset(Offset = "0x18")]
    private Rect m_NormalizedViewportRect;
    [Token(Token = "0x4000BB6")]
    [FieldOffset(Offset = "0x28")]
    private Rect m_ViewportRect;
    [Token(Token = "0x4000BB7")]
    [FieldOffset(Offset = "0x38")]
    private bool m_HasSafeArea;
    [Token(Token = "0x4000BB8")]
    [FieldOffset(Offset = "0x39")]
    private bool m_IsWide;

    [Token(Token = "0x170001C2")]
    public Rect SafeArea
    {
      [Token(Token = "0x6000EB5"), Address(RVA = "0xB05A70", Offset = "0xB04870", VA = "0x10B05A70")] get
      {
        return new Rect();
      }
      [Token(Token = "0x6000EB6"), Address(RVA = "0x11D86D0", Offset = "0x11D74D0", VA = "0x111D86D0")] set
      {
      }
    }

    [Token(Token = "0x170001C3")]
    public Rect NormalizedViewportRect
    {
      [Token(Token = "0x6000EB7"), Address(RVA = "0xAC70F0", Offset = "0xAC5EF0", VA = "0x10AC70F0")] get
      {
        return new Rect();
      }
      [Token(Token = "0x6000EB8"), Address(RVA = "0x11D85E0", Offset = "0x11D73E0", VA = "0x111D85E0")] set
      {
      }
    }

    [Token(Token = "0x170001C4")]
    public Rect ViewportRect
    {
      [Token(Token = "0x6000EB9"), Address(RVA = "0xAA6C50", Offset = "0xAA5A50", VA = "0x10AA6C50")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x170001C5")]
    public bool HasSafeArea
    {
      [Token(Token = "0x6000EBA"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170001C6")]
    public bool IsWide
    {
      [Token(Token = "0x6000EBB"), Address(RVA = "0x34AF90", Offset = "0x349D90", VA = "0x1034AF90")] get
      {
        return new bool();
      }
      [Token(Token = "0x6000EBC"), Address(RVA = "0xFC6290", Offset = "0xFC5090", VA = "0x10FC6290")] set
      {
      }
    }

    [Token(Token = "0x170001C7")]
    public Vector2 ScreenSize
    {
      [Token(Token = "0x6000EBD"), Address(RVA = "0x11D85C0", Offset = "0x11D73C0", VA = "0x111D85C0")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x6000EBE")]
    [Address(RVA = "0x11D8330", Offset = "0x11D7130", VA = "0x111D8330")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6000EBF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ScreenInfo()
    {
    }
  }
}
