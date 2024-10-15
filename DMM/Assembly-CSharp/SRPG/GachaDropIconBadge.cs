// Decompiled with JetBrains decompiler
// Type: SRPG.GachaDropIconBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200240B")]
  [AddComponentMenu("UI/Gacha/GachaDropIconBadge")]
  public class GachaDropIconBadge : SwitchingBadge
  {
    [Token(Token = "0x400A2F3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [CustomField("New", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("バッジ")]
    private GameObject m_NewBadge;
    [Token(Token = "0x400A2F4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [CustomGroup("バッジ")]
    [CustomField("分解済み", CustomFieldAttribute.Type.GameObject)]
    private GameObject m_DisassemblyBadge;
    [Token(Token = "0x400A2F5")]
    [FieldOffset(Offset = "0x24")]
    private GachaHistoryData m_GachaHistoryData;
    [Token(Token = "0x400A2F6")]
    [FieldOffset(Offset = "0x28")]
    private GachaDropData m_GachaDropData;

    [Token(Token = "0x6009CE8")]
    [Address(RVA = "0x600CD0", Offset = "0x5FFAD0", VA = "0x10600CD0", Slot = "4")]
    public override void Refresh()
    {
    }

    [Token(Token = "0x6009CE9")]
    [Address(RVA = "0x600E60", Offset = "0x5FFC60", VA = "0x10600E60")]
    public GachaDropIconBadge()
    {
    }
  }
}
