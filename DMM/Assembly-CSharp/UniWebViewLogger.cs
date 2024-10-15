// Decompiled with JetBrains decompiler
// Type: UniWebViewLogger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000325")]
public class UniWebViewLogger
{
  [Token(Token = "0x4000CE0")]
  [FieldOffset(Offset = "0x0")]
  private static UniWebViewLogger instance;
  [Token(Token = "0x4000CE1")]
  [FieldOffset(Offset = "0x8")]
  private UniWebViewLogger.Level level;

  [Token(Token = "0x170001E4")]
  public UniWebViewLogger.Level LogLevel
  {
    [Token(Token = "0x60010DF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
    {
      return new UniWebViewLogger.Level();
    }
    [Token(Token = "0x60010E0"), Address(RVA = "0x12AB710", Offset = "0x12AA510", VA = "0x112AB710")] set
    {
    }
  }

  [Token(Token = "0x60010E1")]
  [Address(RVA = "0x28EFD0", Offset = "0x28DDD0", VA = "0x1028EFD0")]
  private UniWebViewLogger(UniWebViewLogger.Level level)
  {
  }

  [Token(Token = "0x170001E5")]
  public static UniWebViewLogger Instance
  {
    [Token(Token = "0x60010E2"), Address(RVA = "0x12AB690", Offset = "0x12AA490", VA = "0x112AB690")] get
    {
      return (UniWebViewLogger) null;
    }
  }

  [Token(Token = "0x60010E3")]
  [Address(RVA = "0x12AB620", Offset = "0x12AA420", VA = "0x112AB620")]
  public void Verbose(string message)
  {
  }

  [Token(Token = "0x60010E4")]
  [Address(RVA = "0x12AB4A0", Offset = "0x12AA2A0", VA = "0x112AB4A0")]
  public void Debug(string message)
  {
  }

  [Token(Token = "0x60010E5")]
  [Address(RVA = "0x12AB510", Offset = "0x12AA310", VA = "0x112AB510")]
  public void Info(string message)
  {
  }

  [Token(Token = "0x60010E6")]
  [Address(RVA = "0x12AB430", Offset = "0x12AA230", VA = "0x112AB430")]
  public void Critical(string message)
  {
  }

  [Token(Token = "0x60010E7")]
  [Address(RVA = "0x12AB580", Offset = "0x12AA380", VA = "0x112AB580")]
  private void Log(UniWebViewLogger.Level level, string message)
  {
  }

  [Token(Token = "0x2000326")]
  public enum Level
  {
    [Token(Token = "0x4000CE3")] Verbose = 0,
    [Token(Token = "0x4000CE4")] Debug = 10, // 0x0000000A
    [Token(Token = "0x4000CE5")] Info = 20, // 0x00000014
    [Token(Token = "0x4000CE6")] Critical = 80, // 0x00000050
    [Token(Token = "0x4000CE7")] Off = 99, // 0x00000063
  }
}
