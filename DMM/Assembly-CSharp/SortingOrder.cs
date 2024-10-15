// Decompiled with JetBrains decompiler
// Type: SortingOrder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000163")]
[AddComponentMenu("Rendering/SortingOrder")]
[ExecuteInEditMode]
[RequireComponent(typeof (Renderer))]
public class SortingOrder : MonoBehaviour
{
  [Token(Token = "0x40006C0")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private int mSortingOrder;

  [Token(Token = "0x6000946")]
  [Address(RVA = "0xE61A80", Offset = "0xE60880", VA = "0x10E61A80")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000947")]
  [Address(RVA = "0xE61AA0", Offset = "0xE608A0", VA = "0x10E61AA0")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000948")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public SortingOrder()
  {
  }
}
