// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Describes all the properties of a JobOutput.
    /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
    /// </summary>
    public abstract partial class MediaJobOutput
    {
        /// <summary> Initializes a new instance of MediaJobOutput. </summary>
        protected MediaJobOutput()
        {
        }

        /// <summary> Initializes a new instance of MediaJobOutput. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="error"> If the JobOutput is in the Error state, it contains the details of the error. </param>
        /// <param name="presetOverride">
        /// A preset used to override the preset in the corresponding transform output.
        /// Please note <see cref="MediaTransformPreset"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioAnalyzerPreset"/>, <see cref="BuiltInStandardEncoderPreset"/>, <see cref="StandardEncoderPreset"/> and <see cref="VideoAnalyzerPreset"/>.
        /// </param>
        /// <param name="state"> Describes the state of the JobOutput. </param>
        /// <param name="progress"> If the JobOutput is in a Processing state, this contains the Job completion percentage. The value is an estimate and not intended to be used to predict Job completion times. To determine if the JobOutput is complete, use the State property. </param>
        /// <param name="label"> A label that is assigned to a JobOutput in order to help uniquely identify it. This is useful when your Transform has more than one TransformOutput, whereby your Job has more than one JobOutput. In such cases, when you submit the Job, you will add two or more JobOutputs, in the same order as TransformOutputs in the Transform. Subsequently, when you retrieve the Job, either through events or on a GET request, you can use the label to easily identify the JobOutput. If a label is not provided, a default value of '{presetName}_{outputIndex}' will be used, where the preset name is the name of the preset in the corresponding TransformOutput and the output index is the relative index of the this JobOutput within the Job. Note that this index is the same as the relative index of the corresponding TransformOutput within its Transform. </param>
        /// <param name="startOn"> The UTC date and time at which this Job Output began processing. </param>
        /// <param name="endOn"> The UTC date and time at which this Job Output finished processing. </param>
        internal MediaJobOutput(string odataType, MediaJobError error, MediaTransformPreset presetOverride, MediaJobState? state, int? progress, string label, DateTimeOffset? startOn, DateTimeOffset? endOn)
        {
            OdataType = odataType;
            Error = error;
            PresetOverride = presetOverride;
            State = state;
            Progress = progress;
            Label = label;
            StartOn = startOn;
            EndOn = endOn;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
        /// <summary> If the JobOutput is in the Error state, it contains the details of the error. </summary>
        public MediaJobError Error { get; }
        /// <summary>
        /// A preset used to override the preset in the corresponding transform output.
        /// Please note <see cref="MediaTransformPreset"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioAnalyzerPreset"/>, <see cref="BuiltInStandardEncoderPreset"/>, <see cref="StandardEncoderPreset"/> and <see cref="VideoAnalyzerPreset"/>.
        /// </summary>
        public MediaTransformPreset PresetOverride { get; set; }
        /// <summary> Describes the state of the JobOutput. </summary>
        public MediaJobState? State { get; }
        /// <summary> If the JobOutput is in a Processing state, this contains the Job completion percentage. The value is an estimate and not intended to be used to predict Job completion times. To determine if the JobOutput is complete, use the State property. </summary>
        public int? Progress { get; }
        /// <summary> A label that is assigned to a JobOutput in order to help uniquely identify it. This is useful when your Transform has more than one TransformOutput, whereby your Job has more than one JobOutput. In such cases, when you submit the Job, you will add two or more JobOutputs, in the same order as TransformOutputs in the Transform. Subsequently, when you retrieve the Job, either through events or on a GET request, you can use the label to easily identify the JobOutput. If a label is not provided, a default value of '{presetName}_{outputIndex}' will be used, where the preset name is the name of the preset in the corresponding TransformOutput and the output index is the relative index of the this JobOutput within the Job. Note that this index is the same as the relative index of the corresponding TransformOutput within its Transform. </summary>
        public string Label { get; set; }
        /// <summary> The UTC date and time at which this Job Output began processing. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The UTC date and time at which this Job Output finished processing. </summary>
        public DateTimeOffset? EndOn { get; }
    }
}
