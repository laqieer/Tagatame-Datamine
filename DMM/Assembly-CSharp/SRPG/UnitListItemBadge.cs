// Decompiled with JetBrains decompiler
// Type: SRPG.UnitListItemBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C85")]
  [AddComponentMenu("UI/UnitListItemBadge")]
  public class UnitListItemBadge : MonoBehaviour
  {
    [Token(Token = "0x400DC6D")]
    private const float CHANGE_INTERBAL = 2f;
    [Token(Token = "0x400DC6E")]
    [FieldOffset(Offset = "0xC")]
    [CustomField("強化", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("バッジ")]
    public GameObject m_Badge;
    [Token(Token = "0x400DC6F")]
    [FieldOffset(Offset = "0x10")]
    [CustomGroup("バッジ")]
    [CustomField("ストーリー", CustomFieldAttribute.Type.GameObject)]
    public GameObject m_CharacterQuest;
    [Token(Token = "0x400DC70")]
    [FieldOffset(Offset = "0x14")]
    [CustomField("お気に入り", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("バッジ")]
    public GameObject m_Favorite;
    [Token(Token = "0x400DC71")]
    [FieldOffset(Offset = "0x18")]
    [CustomField("開眼マスター", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("バッジ")]
    public GameObject m_DoorMaster;
    [Token(Token = "0x400DC72")]
    [FieldOffset(Offset = "0x1C")]
    private UnitParam m_UnitParam;
    [Token(Token = "0x400DC73")]
    [FieldOffset(Offset = "0x20")]
    private UnitData m_UnitData;
    [Token(Token = "0x400DC74")]
    [FieldOffset(Offset = "0x24")]
    private List<GameObject> m_DispOn;
    [Token(Token = "0x400DC75")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> m_DispOff;
    [Token(Token = "0x400DC76")]
    [FieldOffset(Offset = "0x2C")]
    private int m_Index;
    [Token(Token = "0x400DC77")]
    [FieldOffset(Offset = "0x30")]
    private float m_Time;

    [Token(Token = "0x600CE61")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600CE62")]
    [Address(RVA = "0x995440", Offset = "0x994240", VA = "0x10995440")]
    private void Update()
    {
    }

    [Token(Token = "0x600CE63")]
    [Address(RVA = "0x995440", Offset = "0x994240", VA = "0x10995440")]
    private void UpdateBadge()
    {
    }

    [Token(Token = "0x600CE64")]
    [Address(RVA = "0x995250", Offset = "0x994050", VA = "0x10995250")]
    private void UpdateBadgeAlternate(int index)
    {
    }

    [Token(Token = "0x600CE65")]
    [Address(RVA = "0x994D80", Offset = "0x993B80", VA = "0x10994D80")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600CE66")]
    [Address(RVA = "0x994D70", Offset = "0x993B70", VA = "0x10994D70")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600CE67")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600CE68")]
    [Address(RVA = "0x9954E0", Offset = "0x9942E0", VA = "0x109954E0")]
    public UnitListItemBadge()
    {
    }
  }
}
