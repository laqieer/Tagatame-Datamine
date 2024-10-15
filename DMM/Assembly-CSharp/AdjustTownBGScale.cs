// Decompiled with JetBrains decompiler
// Type: AdjustTownBGScale
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000289")]
[AddComponentMenu("UI/AdjustTownBGScale")]
public class AdjustTownBGScale : MonoBehaviour
{
  [Token(Token = "0x4000AA5")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private float RevisionScaleValue;
  [Token(Token = "0x4000AA6")]
  [FieldOffset(Offset = "0x10")]
  private bool m_set_scale_safe_area;
  [Token(Token = "0x4000AA7")]
  [FieldOffset(Offset = "0x14")]
  private Vector3 m_init_scale;
  [Token(Token = "0x4000AA8")]
  [FieldOffset(Offset = "0x20")]
  private Rect m_safe_area;

  [Token(Token = "0x17000197")]
  public float RevisionScale
  {
    [Token(Token = "0x6000D88"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x6000D89")]
  [Address(RVA = "0x11CB210", Offset = "0x11CA010", VA = "0x111CB210")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D8A")]
  [Address(RVA = "0x11CB130", Offset = "0x11C9F30", VA = "0x111CB130")]
  private void SetScale()
  {
  }

  [Token(Token = "0x6000D8B")]
  [Address(RVA = "0x11CB320", Offset = "0x11CA120", VA = "0x111CB320")]
  public AdjustTownBGScale()
  {
  }
}
