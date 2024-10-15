// Decompiled with JetBrains decompiler
// Type: SRPG.GachaDropIconNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200240C")]
  [AddComponentMenu("UI/Gacha/GachaDropIconNode")]
  public class GachaDropIconNode : ContentNode
  {
    [Token(Token = "0x400A2F7")]
    [FieldOffset(Offset = "0x30")]
    [Header("ユニットアイコン")]
    [SerializeField]
    private GameObject DropUnit;
    [Token(Token = "0x400A2F8")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    [Header("アイテムアイコン")]
    private GameObject DropItem;
    [Token(Token = "0x400A2F9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Header("武具アイコン")]
    private GameObject DropArtifact;
    [Token(Token = "0x400A2FA")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    [Header("真理念装アイコン")]
    private GameObject DropConceptCard;
    [Token(Token = "0x400A2FB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("選択中バッジ")]
    private GameObject SelectedBadge;
    [Token(Token = "0x400A2FC")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject DropCrystal;
    [Token(Token = "0x400A2FD")]
    [FieldOffset(Offset = "0x48")]
    private GachaDropData mDropData;

    [Token(Token = "0x170015D8")]
    public GachaDropData DropData
    {
      [Token(Token = "0x6009CEA"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (GachaDropData) null;
      }
    }

    [Token(Token = "0x6009CEB")]
    [Address(RVA = "0x600E70", Offset = "0x5FFC70", VA = "0x10600E70")]
    public void Reset()
    {
    }

    [Token(Token = "0x6009CEC")]
    [Address(RVA = "0x601050", Offset = "0x5FFE50", VA = "0x10601050")]
    public void Select(bool select)
    {
    }

    [Token(Token = "0x6009CED")]
    [Address(RVA = "0x6010A0", Offset = "0x5FFEA0", VA = "0x106010A0")]
    public void Setup(GachaDropData drop_data, bool is_select = false)
    {
    }

    [Token(Token = "0x6009CEE")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public GachaDropIconNode()
    {
    }
  }
}
