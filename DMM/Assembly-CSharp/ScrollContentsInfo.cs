// Decompiled with JetBrains decompiler
// Type: ScrollContentsInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002CE")]
[AddComponentMenu("UI/ScrollContentsInfo")]
public class ScrollContentsInfo : MonoBehaviour
{
  [Token(Token = "0x4000BA2")]
  [FieldOffset(Offset = "0xC")]
  protected float mStartPosX;
  [Token(Token = "0x4000BA3")]
  [FieldOffset(Offset = "0x10")]
  protected float mEndPosX;
  [Token(Token = "0x4000BA4")]
  [FieldOffset(Offset = "0x14")]
  protected float mStartPosY;
  [Token(Token = "0x4000BA5")]
  [FieldOffset(Offset = "0x18")]
  protected float mEndPosY;

  [Token(Token = "0x6000EA0")]
  [Address(RVA = "0x11D8770", Offset = "0x11D7570", VA = "0x111D8770")]
  private void Start()
  {
  }

  [Token(Token = "0x6000EA1")]
  [Address(RVA = "0x3FE720", Offset = "0x3FD520", VA = "0x103FE720", Slot = "4")]
  public virtual Vector2 SetRangePos(Vector2 position) => new Vector2();

  [Token(Token = "0x6000EA2")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "5")]
  public virtual bool CheckRangePos(float pos) => new bool();

  [Token(Token = "0x6000EA3")]
  [Address(RVA = "0x11D8760", Offset = "0x11D7560", VA = "0x111D8760", Slot = "6")]
  public virtual float GetNearIconPos(float pos) => new float();

  [Token(Token = "0x6000EA4")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public ScrollContentsInfo()
  {
  }
}
