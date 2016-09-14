import { Action } from "@ngrx/store";
import { GET_CONTENT_SUCCESS } from "../constants";
import { initialState } from "./initial-state";
import { AppState } from "./app-state";
import { addOrUpdate, pluckOut } from "../utilities";
import { Content } from "../models";

export const contentsReducer = (state: AppState = initialState, action: Action) => {
    switch (action.type) {
        case GET_CONTENT_SUCCESS:
            var entities: Array<Content> = state.contents;
            var newOrExistingContents: Array<Content> = action.payload;
            for (let i = 0; i < newOrExistingContents.length; i++) {
                addOrUpdate({ items: entities, item: newOrExistingContents[i], key:"type" });
            }                                    
            return Object.assign({}, state, { contents: entities });

        default:
            return state;
    }
}

