// Decompiled with JetBrains decompiler
// Type: SRPG.DeriveListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022F2")]
  [AddComponentMenu("UI/DeriveListItem")]
  public class DeriveListItem : MonoBehaviour
  {
    [Token(Token = "0x4009BC2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼派生先のスキル/アビリティの罫線")]
    private RectTransform m_DeriveLineV;
    [Token(Token = "0x4009BC3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RectTransform m_DeriveLineH;

    [Token(Token = "0x600963D")]
    [Address(RVA = "0x58FB40", Offset = "0x58E940", VA = "0x1058FB40")]
    public void SetLineActive(bool lineActive, bool verticalActive)
    {
    }

    [Token(Token = "0x600963E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DeriveListItem()
    {
    }
  }
}
