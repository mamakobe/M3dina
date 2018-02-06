/**
  * Move Patient to a new facility
  * @param  {org.medina.referral.MovePatient} movePatient - the move patient transaction
  * @transaction
  */
  function MovePatient(movePatient) {
    movePatient.patient.currentFacility = movePatient.receivingFacility;
    return getAssetRegistry('org.medina.referral.Patient')
      .then(function (assetRegistry) {
        return assetRegistry.update(movePatient.patient);
      });
  }