// Decompiled with JetBrains decompiler
// Type: BundleSceneRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000091")]
public class BundleSceneRequest : SceneRequest
{
  [Token(Token = "0x40002D3")]
  [FieldOffset(Offset = "0xC")]
  private bool mSceneActivated;
  [Token(Token = "0x40002D4")]
  [FieldOffset(Offset = "0xD")]
  private bool mAdditive;
  [Token(Token = "0x40002D5")]
  [FieldOffset(Offset = "0x10")]
  private LoadRequest mRequest;

  [Token(Token = "0x6000383")]
  [Address(RVA = "0xB82A00", Offset = "0xB81800", VA = "0x10B82A00", Slot = "7")]
  public override bool ActivateScene() => new bool();

  [Token(Token = "0x1700009B")]
  public override bool IsActivated
  {
    [Token(Token = "0x6000384"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80", Slot = "8")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000385")]
  [Address(RVA = "0xB82BB0", Offset = "0xB819B0", VA = "0x10B82BB0")]
  public BundleSceneRequest(LoadRequest request, bool additive)
  {
  }

  [Token(Token = "0x1700009C")]
  public override bool isAdditive
  {
    [Token(Token = "0x6000386"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450", Slot = "15")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700009D")]
  public override bool canBeActivated
  {
    [Token(Token = "0x6000387"), Address(RVA = "0xB82BE0", Offset = "0xB819E0", VA = "0x10B82BE0", Slot = "10")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700009E")]
  public override bool isDone
  {
    [Token(Token = "0x6000388"), Address(RVA = "0xB82C10", Offset = "0xB81A10", VA = "0x10B82C10", Slot = "9")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000389")]
  [Address(RVA = "0xB82B80", Offset = "0xB81980", VA = "0x10B82B80", Slot = "12")]
  public override bool MoveNext() => new bool();

  [Token(Token = "0x1700009F")]
  public override object Current
  {
    [Token(Token = "0x600038A"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "13")] get
    {
      return (object) null;
    }
  }

  [Token(Token = "0x170000A0")]
  public override float progress
  {
    [Token(Token = "0x600038B"), Address(RVA = "0xB82C60", Offset = "0xB81A60", VA = "0x10B82C60", Slot = "14")] get
    {
      return new float();
    }
  }
}
