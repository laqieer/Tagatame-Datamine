// Decompiled with JetBrains decompiler
// Type: IntentHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000009")]
public class IntentHandler
{
  [Token(Token = "0x400001B")]
  [FieldOffset(Offset = "0x0")]
  private static IntentHandler instance;

  [Token(Token = "0x600002D")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public IntentHandler()
  {
  }

  [Token(Token = "0x600002E")]
  [Address(RVA = "0x2C6320", Offset = "0x2C5120", VA = "0x102C6320")]
  public static IntentHandler GetInstance() => (IntentHandler) null;

  [Token(Token = "0x600002F")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void ClearIntentHandlers()
  {
  }

  [Token(Token = "0x6000030")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void AddNoopIntentHandler()
  {
  }

  [Token(Token = "0x6000031")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void AddUrlIntentHandler()
  {
  }

  [Token(Token = "0x6000032")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void AddCustomIntentHandler(string gameObjectName, string methodName)
  {
  }

  [Token(Token = "0x6000033")]
  [Address(RVA = "0x2C6360", Offset = "0x2C5160", VA = "0x102C6360")]
  static IntentHandler()
  {
  }
}
