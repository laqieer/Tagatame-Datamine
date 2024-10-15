// Decompiled with JetBrains decompiler
// Type: SRPG.GachaAnimationParts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002404")]
  [AddComponentMenu("UI/Gacha/GachaAnimationParts")]
  public class GachaAnimationParts : MonoBehaviour
  {
    [Token(Token = "0x400A2C2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject[] LowObjects;
    [Token(Token = "0x400A2C3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject[] MiddleObjects;
    [Token(Token = "0x400A2C4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject[] HighObjects;
    [Token(Token = "0x400A2C5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GachaAnimationParts.StateType SType;

    [Token(Token = "0x170015CD")]
    public GachaAnimationParts.StateType state
    {
      [Token(Token = "0x6009CB4"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new GachaAnimationParts.StateType();
      }
    }

    [Token(Token = "0x6009CB5")]
    [Address(RVA = "0x5F9140", Offset = "0x5F7F40", VA = "0x105F9140")]
    public void Setup(int excite)
    {
    }

    [Token(Token = "0x6009CB6")]
    [Address(RVA = "0x5F8F40", Offset = "0x5F7D40", VA = "0x105F8F40")]
    private void Reset()
    {
    }

    [Token(Token = "0x6009CB7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaAnimationParts()
    {
    }

    [Token(Token = "0x2002405")]
    public enum StateType : byte
    {
      [Token(Token = "0x400A2C7")] None,
      [Token(Token = "0x400A2C8")] Before,
      [Token(Token = "0x400A2C9")] After,
    }
  }
}
