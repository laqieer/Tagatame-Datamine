// Decompiled with JetBrains decompiler
// Type: SRPG.QuestListItemExtention
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002899")]
  [AddComponentMenu("UI/QuestListItemExtention")]
  public class QuestListItemExtention : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x400C249")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private LayoutElement m_LayoutElement;
    [Token(Token = "0x400C24A")]
    [FieldOffset(Offset = "0x10")]
    private Vector2 m_InitialLayoutElementMinSize;
    [Token(Token = "0x400C24B")]
    [FieldOffset(Offset = "0x18")]
    private Vector2 m_InitialLayoutElementPreferredSize;

    [Token(Token = "0x600B782")]
    [Address(RVA = "0x7E3CB0", Offset = "0x7E2AB0", VA = "0x107E3CB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B783")]
    [Address(RVA = "0x7E3D80", Offset = "0x7E2B80", VA = "0x107E3D80", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600B784")]
    [Address(RVA = "0x7E3DA0", Offset = "0x7E2BA0", VA = "0x107E3DA0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B785")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public QuestListItemExtention()
    {
    }
  }
}
