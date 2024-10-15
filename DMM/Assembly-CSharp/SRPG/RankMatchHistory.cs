// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002917")]
  [AddComponentMenu("UI/RankMatchHistory")]
  public class RankMatchHistory : SRPG_ListBase
  {
    [Token(Token = "0x400C5EF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject PlayerGO;
    [Token(Token = "0x400C5F0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ListItemEvents ListItem;
    [Token(Token = "0x400C5F1")]
    [FieldOffset(Offset = "0x28")]
    [Space(10f)]
    [SerializeField]
    private Text LastBattleDate;

    [Token(Token = "0x600B9F9")]
    [Address(RVA = "0x80F750", Offset = "0x80E550", VA = "0x1080F750", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600B9FA")]
    [Address(RVA = "0x80F000", Offset = "0x80DE00", VA = "0x1080F000")]
    private void ResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600B9FB")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public RankMatchHistory()
    {
    }
  }
}
