// Decompiled with JetBrains decompiler
// Type: SceneRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
[Token(Token = "0x200008F")]
public abstract class SceneRequest : IEnumerator
{
  [Token(Token = "0x40002CF")]
  [FieldOffset(Offset = "0x8")]
  public string SceneName;

  [Token(Token = "0x6000370")]
  public abstract bool ActivateScene();

  [Token(Token = "0x1700008F")]
  public abstract bool IsActivated { [Token(Token = "0x6000371")] get; }

  [Token(Token = "0x17000090")]
  public abstract bool isDone { [Token(Token = "0x6000372")] get; }

  [Token(Token = "0x17000091")]
  public abstract bool canBeActivated { [Token(Token = "0x6000373")] get; }

  [Token(Token = "0x6000374")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "11")]
  public virtual void Reset()
  {
  }

  [Token(Token = "0x6000375")]
  public abstract bool MoveNext();

  [Token(Token = "0x17000092")]
  public abstract object Current { [Token(Token = "0x6000376")] get; }

  [Token(Token = "0x17000093")]
  public virtual float progress
  {
    [Token(Token = "0x6000377"), Address(RVA = "0xB8D670", Offset = "0xB8C470", VA = "0x10B8D670", Slot = "14")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x17000094")]
  public abstract bool isAdditive { [Token(Token = "0x6000378")] get; }

  [Token(Token = "0x6000379")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  protected SceneRequest()
  {
  }
}
