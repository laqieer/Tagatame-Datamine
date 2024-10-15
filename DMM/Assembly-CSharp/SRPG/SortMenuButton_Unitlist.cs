// Decompiled with JetBrains decompiler
// Type: SRPG.SortMenuButton_Unitlist
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AF2")]
  public class SortMenuButton_Unitlist : SortMenuButton
  {
    [Token(Token = "0x400D191")]
    [FieldOffset(Offset = "0xE0")]
    public Image FilterButton;
    [Token(Token = "0x400D192")]
    [FieldOffset(Offset = "0xE4")]
    public Sprite Active;
    [Token(Token = "0x400D193")]
    [FieldOffset(Offset = "0xE8")]
    public Sprite NonActive;
    [Token(Token = "0x400D194")]
    [FieldOffset(Offset = "0xEC")]
    public Text Msg;
    [Token(Token = "0x400D195")]
    [FieldOffset(Offset = "0xF0")]
    private Coroutine mCoroutine;
    [Token(Token = "0x400D196")]
    [FieldOffset(Offset = "0xF4")]
    private bool mRequest;
    [Token(Token = "0x400D197")]
    [FieldOffset(Offset = "0xF5")]
    private bool mFlag;

    [Token(Token = "0x600C452")]
    [Address(RVA = "0x8CE230", Offset = "0x8CD030", VA = "0x108CE230", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C453")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    protected override void OnEnable()
    {
    }

    [Token(Token = "0x600C454")]
    [Address(RVA = "0x8CE240", Offset = "0x8CD040", VA = "0x108CE240", Slot = "45")]
    protected override void UpdateFilterState(bool active)
    {
    }

    [Token(Token = "0x600C455")]
    [Address(RVA = "0x8CE2D0", Offset = "0x8CD0D0", VA = "0x108CE2D0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C456")]
    [Address(RVA = "0x8CE260", Offset = "0x8CD060", VA = "0x108CE260")]
    private IEnumerator UpdateState(bool active) => (IEnumerator) null;

    [Token(Token = "0x600C457")]
    [Address(RVA = "0x8CE380", Offset = "0x8CD180", VA = "0x108CE380")]
    public SortMenuButton_Unitlist()
    {
    }
  }
}
