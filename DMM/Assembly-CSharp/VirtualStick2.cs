// Decompiled with JetBrains decompiler
// Type: VirtualStick2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000189")]
[AddComponentMenu("Common/VirtualStick2")]
public class VirtualStick2 : MonoBehaviour
{
  [Token(Token = "0x4000772")]
  [FieldOffset(Offset = "0xC")]
  private RectTransform mTransform;
  [Token(Token = "0x4000773")]
  [FieldOffset(Offset = "0x10")]
  public RectTransform Knob;
  [Token(Token = "0x4000774")]
  [FieldOffset(Offset = "0x14")]
  public float Radius;
  [Token(Token = "0x4000775")]
  [FieldOffset(Offset = "0x18")]
  private Animator mAnimator;
  [Token(Token = "0x4000776")]
  [FieldOffset(Offset = "0x1C")]
  private Vector2 mInputDelta;
  [Token(Token = "0x4000777")]
  [FieldOffset(Offset = "0x24")]
  private bool mVisible;
  [Token(Token = "0x4000778")]
  [FieldOffset(Offset = "0x28")]
  public string VisibleBool;

  [Token(Token = "0x60009AE")]
  [Address(RVA = "0xF54EB0", Offset = "0xF53CB0", VA = "0x10F54EB0")]
  private void Start()
  {
  }

  [Token(Token = "0x60009AF")]
  [Address(RVA = "0xF54E80", Offset = "0xF53C80", VA = "0x10F54E80")]
  public void SetPosition(Vector2 position)
  {
  }

  [Token(Token = "0x1700014C")]
  public bool Visible
  {
    [Token(Token = "0x60009B0"), Address(RVA = "0xF551C0", Offset = "0xF53FC0", VA = "0x10F551C0")] set
    {
    }
    [Token(Token = "0x60009B1"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700014D")]
  public Vector2 Delta
  {
    [Token(Token = "0x60009B2"), Address(RVA = "0xF55070", Offset = "0xF53E70", VA = "0x10F55070")] set
    {
    }
  }

  [Token(Token = "0x1700014E")]
  public Vector2 Velocity
  {
    [Token(Token = "0x60009B3"), Address(RVA = "0xF55030", Offset = "0xF53E30", VA = "0x10F55030")] get
    {
      return new Vector2();
    }
  }

  [Token(Token = "0x60009B4")]
  [Address(RVA = "0xF54F50", Offset = "0xF53D50", VA = "0x10F54F50")]
  private void Update()
  {
  }

  [Token(Token = "0x60009B5")]
  [Address(RVA = "0xF54FE0", Offset = "0xF53DE0", VA = "0x10F54FE0")]
  public VirtualStick2()
  {
  }
}
