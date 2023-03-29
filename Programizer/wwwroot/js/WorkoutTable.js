import React, { useState } from 'react';

class WorkoutTable extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            label: "Bench",
            sets: 3,
            reps: 10,
        }
    }
    render() {
        return(
            <div>
                <h1>{ this.state.label }</h1>
                <h1>{ this.state.sets }</h1>
                <h1>{ this.state.reps }</h1>
            </div>
        );
    }
}