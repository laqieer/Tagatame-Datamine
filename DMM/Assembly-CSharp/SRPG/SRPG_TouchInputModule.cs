// Decompiled with JetBrains decompiler
// Type: SRPG.SRPG_TouchInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AFB")]
  [AddComponentMenu("Event/Touch Input Module (SRPG)")]
  public class SRPG_TouchInputModule : PointerInputModule
  {
    [Token(Token = "0x400D1BB")]
    [FieldOffset(Offset = "0x0")]
    private static int mLockCount;
    [Token(Token = "0x400D1BD")]
    [FieldOffset(Offset = "0x34")]
    public GameObject TouchEffect;
    [Token(Token = "0x400D1BE")]
    [FieldOffset(Offset = "0x38")]
    private GameObject[] mTouchEffectPool;
    [Token(Token = "0x400D1BF")]
    [FieldOffset(Offset = "0x3C")]
    private int mNumActiveTouchEffects;
    [Token(Token = "0x400D1C0")]
    [FieldOffset(Offset = "0x40")]
    private bool mTouchEffectPoolInitialized;
    [Token(Token = "0x400D1C1")]
    [FieldOffset(Offset = "0x44")]
    public SRPG_TouchInputModule.OnDoubleTapDelegate OnDoubleTap;
    [Token(Token = "0x400D1C2")]
    [FieldOffset(Offset = "0x48")]
    private float mDoubleTap1stReleasedTime;
    [Token(Token = "0x400D1C3")]
    [FieldOffset(Offset = "0x4C")]
    private readonly int BUTTON_INDEX_MAX;
    [Token(Token = "0x400D1C4")]
    [FieldOffset(Offset = "0x50")]
    private int pressing_button_index;
    [Token(Token = "0x400D1C5")]
    [FieldOffset(Offset = "0x4")]
    public static bool IsMultiTouching;
    [Token(Token = "0x400D1C6")]
    [FieldOffset(Offset = "0x54")]
    private Vector2 m_LastMousePosition;
    [Token(Token = "0x400D1C7")]
    [FieldOffset(Offset = "0x5C")]
    private Vector2 m_MousePosition;
    [Token(Token = "0x400D1C8")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private bool m_AllowActivationOnStandalone;
    [Token(Token = "0x400D1C9")]
    [FieldOffset(Offset = "0x68")]
    private int mPrimaryFingerID;

    [Token(Token = "0x600C4B0")]
    [Address(RVA = "0x8D2310", Offset = "0x8D1110", VA = "0x108D2310")]
    public static void LockInput()
    {
    }

    [Token(Token = "0x600C4B1")]
    [Address(RVA = "0x8D3980", Offset = "0x8D2780", VA = "0x108D3980")]
    public static void UnlockInput(bool forceReset = false)
    {
    }

    [Token(Token = "0x17001A2D")]
    private bool IsHandling
    {
      [Token(Token = "0x600C4B2"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C4B3"), Address(RVA = "0x3A1250", Offset = "0x3A0050", VA = "0x103A1250")] set
      {
      }
    }

    [Token(Token = "0x600C4B4")]
    [Address(RVA = "0x8D2140", Offset = "0x8D0F40", VA = "0x108D2140")]
    private void InitTouchEffects()
    {
    }

    [Token(Token = "0x600C4B5")]
    [Address(RVA = "0x8D3500", Offset = "0x8D2300", VA = "0x108D3500", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x17001A2E")]
    public bool allowActivationOnStandalone
    {
      [Token(Token = "0x600C4B6"), Address(RVA = "0x8D3C80", Offset = "0x8D2A80", VA = "0x108D3C80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C4B7"), Address(RVA = "0x8D3C90", Offset = "0x8D2A90", VA = "0x108D3C90")] set
      {
      }
    }

    [Token(Token = "0x600C4B8")]
    [Address(RVA = "0x8D3A10", Offset = "0x8D2810", VA = "0x108D3A10", Slot = "24")]
    public override void UpdateModule()
    {
    }

    [Token(Token = "0x600C4B9")]
    [Address(RVA = "0x8D22F0", Offset = "0x8D10F0", VA = "0x108D22F0", Slot = "25")]
    public override bool IsModuleSupported() => new bool();

    [Token(Token = "0x600C4BA")]
    [Address(RVA = "0x8D3200", Offset = "0x8D2000", VA = "0x108D3200", Slot = "21")]
    public override bool ShouldActivateModule() => new bool();

    [Token(Token = "0x600C4BB")]
    [Address(RVA = "0x8D3C00", Offset = "0x8D2A00", VA = "0x108D3C00")]
    private bool UseFakeInput() => new bool();

    [Token(Token = "0x600C4BC")]
    [Address(RVA = "0x8D2EF0", Offset = "0x8D1CF0", VA = "0x108D2EF0", Slot = "17")]
    public override void Process()
    {
    }

    [Token(Token = "0x600C4BD")]
    [Address(RVA = "0x8D30E0", Offset = "0x8D1EE0", VA = "0x108D30E0")]
    private bool SendUpdateEventToSelectedObject() => new bool();

    [Token(Token = "0x600C4BE")]
    [Address(RVA = "0x8D1ED0", Offset = "0x8D0CD0", VA = "0x108D1ED0")]
    private PointerEventData GetMousePointerEvent(int index) => (PointerEventData) null;

    [Token(Token = "0x600C4BF")]
    [Address(RVA = "0x8D1BA0", Offset = "0x8D09A0", VA = "0x108D1BA0")]
    private void FakeTouches()
    {
    }

    [Token(Token = "0x600C4C0")]
    [Address(RVA = "0x8D2390", Offset = "0x8D1190", VA = "0x108D2390")]
    private void ProcessTouchEvents()
    {
    }

    [Token(Token = "0x600C4C1")]
    [Address(RVA = "0x8D2760", Offset = "0x8D1560", VA = "0x108D2760")]
    private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
    {
    }

    [Token(Token = "0x600C4C2")]
    [Address(RVA = "0x8D1B80", Offset = "0x8D0980", VA = "0x108D1B80", Slot = "22")]
    public override void DeactivateModule()
    {
    }

    [Token(Token = "0x600C4C3")]
    [Address(RVA = "0x8D36F0", Offset = "0x8D24F0", VA = "0x108D36F0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600C4C4")]
    [Address(RVA = "0x8D3340", Offset = "0x8D2140", VA = "0x108D3340")]
    private void SpawnTouchEffect(Vector2 position)
    {
    }

    [Token(Token = "0x600C4C5")]
    [Address(RVA = "0x8D3A60", Offset = "0x8D2860", VA = "0x108D3A60")]
    private void UpdateTouchEffects()
    {
    }

    [Token(Token = "0x600C4C6")]
    [Address(RVA = "0x8D3BE0", Offset = "0x8D29E0", VA = "0x108D3BE0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C4C7")]
    [Address(RVA = "0x8D3C10", Offset = "0x8D2A10", VA = "0x108D3C10")]
    public SRPG_TouchInputModule()
    {
    }

    [Token(Token = "0x2002AFC")]
    public delegate void OnDoubleTapDelegate(Vector2 position);
  }
}
