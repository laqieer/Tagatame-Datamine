// Decompiled with JetBrains decompiler
// Type: UIDraftMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002E9")]
[RequireComponent(typeof (RectTransform))]
[ExecuteInEditMode]
[AddComponentMenu("UI/Expose")]
public class UIDraftMember : MonoBehaviour
{
  [Token(Token = "0x4000C20")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private bool mSearchGraphicComponent;
  [Token(Token = "0x4000C21")]
  [FieldOffset(Offset = "0xD")]
  public bool UseGraphic;

  [Token(Token = "0x6000F11")]
  [Address(RVA = "0x12A7150", Offset = "0x12A5F50", VA = "0x112A7150")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000F12")]
  [Address(RVA = "0x11CCBA0", Offset = "0x11CB9A0", VA = "0x111CCBA0")]
  public UIDraftMember()
  {
  }
}
