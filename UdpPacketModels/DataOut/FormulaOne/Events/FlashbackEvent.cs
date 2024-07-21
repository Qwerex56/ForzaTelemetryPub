namespace ForzaTelemetry.ForzaModels.DataOut.FormulaOne.Events;

public record FlashbackEvent(
    uint FlashBackFrameIdentifier,
    float FlashBackSessionTime);