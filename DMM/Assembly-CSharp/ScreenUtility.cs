// Decompiled with JetBrains decompiler
// Type: ScreenUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000147")]
public static class ScreenUtility
{
  [Token(Token = "0x4000648")]
  [FieldOffset(Offset = "0x0")]
  private static int mDefaultScreenWidth;
  [Token(Token = "0x4000649")]
  [FieldOffset(Offset = "0x4")]
  private static int mDefaultScreenHeight;
  [Token(Token = "0x400064A")]
  public const int MIN_WINDOW_WIDTH = 480;
  [Token(Token = "0x400064B")]
  public const int MIN_WINDOW_HEIGHT = 270;
  [Token(Token = "0x400064C")]
  public const int DEFAULT_WINDOW_WIDTH = 1920;
  [Token(Token = "0x400064D")]
  public const int DEFAULT_WINDOW_HEIGHT = 1080;
  [Token(Token = "0x400064E")]
  public const float ASPECT_RATIO = 1.77777779f;

  [Token(Token = "0x60007FA")]
  [Address(RVA = "0xE51C10", Offset = "0xE50A10", VA = "0x10E51C10")]
  static ScreenUtility()
  {
  }

  [Token(Token = "0x60007FB")]
  [Address(RVA = "0xE51BF0", Offset = "0xE509F0", VA = "0x10E51BF0")]
  public static void SetResolution(int w, int h)
  {
  }

  [Token(Token = "0x17000124")]
  public static int DefaultScreenWidth
  {
    [Token(Token = "0x60007FC"), Address(RVA = "0xE51C90", Offset = "0xE50A90", VA = "0x10E51C90")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x17000125")]
  public static int DefaultScreenHeight
  {
    [Token(Token = "0x60007FD"), Address(RVA = "0xE51C50", Offset = "0xE50A50", VA = "0x10E51C50")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x17000126")]
  public static float ScreenWidthScale
  {
    [Token(Token = "0x60007FE"), Address(RVA = "0xE51D40", Offset = "0xE50B40", VA = "0x10E51D40")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x17000127")]
  public static float ScreenHeightScale
  {
    [Token(Token = "0x60007FF"), Address(RVA = "0xE51CD0", Offset = "0xE50AD0", VA = "0x10E51CD0")] get
    {
      return new float();
    }
  }
}
