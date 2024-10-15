// Decompiled with JetBrains decompiler
// Type: DefaultSceneRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000090")]
public class DefaultSceneRequest : SceneRequest
{
  [Token(Token = "0x40002D0")]
  [FieldOffset(Offset = "0xC")]
  private bool mSceneActivated;
  [Token(Token = "0x40002D1")]
  [FieldOffset(Offset = "0x10")]
  private AsyncOperation mRequest;
  [Token(Token = "0x40002D2")]
  [FieldOffset(Offset = "0x14")]
  private bool mAdditive;

  [Token(Token = "0x600037A")]
  [Address(RVA = "0xB85480", Offset = "0xB84280", VA = "0x10B85480", Slot = "7")]
  public override bool ActivateScene() => new bool();

  [Token(Token = "0x17000095")]
  public override bool IsActivated
  {
    [Token(Token = "0x600037B"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80", Slot = "8")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x17000096")]
  public override bool isAdditive
  {
    [Token(Token = "0x600037C"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0", Slot = "15")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x600037D")]
  [Address(RVA = "0xB855A0", Offset = "0xB843A0", VA = "0x10B855A0")]
  public DefaultSceneRequest(AsyncOperation request, bool additive)
  {
  }

  [Token(Token = "0x17000097")]
  public override bool isDone
  {
    [Token(Token = "0x600037E"), Address(RVA = "0xB85630", Offset = "0xB84430", VA = "0x10B85630", Slot = "9")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x17000098")]
  public override bool canBeActivated
  {
    [Token(Token = "0x600037F"), Address(RVA = "0xB855F0", Offset = "0xB843F0", VA = "0x10B855F0", Slot = "10")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000380")]
  [Address(RVA = "0xB85570", Offset = "0xB84370", VA = "0x10B85570", Slot = "12")]
  public override bool MoveNext() => new bool();

  [Token(Token = "0x17000099")]
  public override object Current
  {
    [Token(Token = "0x6000381"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "13")] get
    {
      return (object) null;
    }
  }

  [Token(Token = "0x1700009A")]
  public override float progress
  {
    [Token(Token = "0x6000382"), Address(RVA = "0xB85660", Offset = "0xB84460", VA = "0x10B85660", Slot = "14")] get
    {
      return new float();
    }
  }
}
