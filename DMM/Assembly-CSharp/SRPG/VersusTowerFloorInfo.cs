// Decompiled with JetBrains decompiler
// Type: SRPG.VersusTowerFloorInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002757")]
  [AddComponentMenu("UI/Multi/Versus/VersusTowerFloorInfo")]
  public class VersusTowerFloorInfo : MonoBehaviour
  {
    [Token(Token = "0x400B9B8")]
    [FieldOffset(Offset = "0xC")]
    private readonly int ScrollMargin;
    [Token(Token = "0x400B9B9")]
    [FieldOffset(Offset = "0x10")]
    private readonly float ScrollSpd;
    [Token(Token = "0x400B9BA")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Keytemplate;
    [Token(Token = "0x400B9BB")]
    [FieldOffset(Offset = "0x18")]
    public GameObject parent;
    [Token(Token = "0x400B9BC")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject playerInfo;
    [Token(Token = "0x400B9BD")]
    [FieldOffset(Offset = "0x20")]
    public ScrollListController ScrollCtrl;
    [Token(Token = "0x400B9BE")]
    [FieldOffset(Offset = "0x24")]
    public Button currentButton;
    [Token(Token = "0x400B9BF")]
    [FieldOffset(Offset = "0x28")]
    public ScrollRect Scroll;
    [Token(Token = "0x400B9C0")]
    [FieldOffset(Offset = "0x2C")]
    private float AutoScrollGoal;
    [Token(Token = "0x400B9C1")]
    [FieldOffset(Offset = "0x30")]
    private bool AutoScroll;

    [Token(Token = "0x600B085")]
    [Address(RVA = "0x751E60", Offset = "0x750C60", VA = "0x10751E60")]
    private void Start()
    {
    }

    [Token(Token = "0x600B086")]
    [Address(RVA = "0x751BA0", Offset = "0x7509A0", VA = "0x10751BA0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B087")]
    [Address(RVA = "0x751F20", Offset = "0x750D20", VA = "0x10751F20")]
    public void Update()
    {
    }

    [Token(Token = "0x600B088")]
    [Address(RVA = "0x751A60", Offset = "0x750860", VA = "0x10751A60")]
    private void OnClickScroll()
    {
    }

    [Token(Token = "0x600B089")]
    [Address(RVA = "0x752180", Offset = "0x750F80", VA = "0x10752180")]
    public VersusTowerFloorInfo()
    {
    }
  }
}
